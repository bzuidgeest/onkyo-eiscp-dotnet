using Eiscp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace generate
{
    internal class DocumentationWindow : Window
    {
        private ListView modelListView;
        private ListView commandListView;
        private ListView zoneListView;
        private Label commandDescriptionLabel;

        private FrameView valuesFrameView;
        private ScrollView valuesScrollView;

        private string selectedModel = "";
        private string selectedZone = "";
        private string selectedCommand = "";

        private List<ISCPCommandDocumentation> commands;
        public DocumentationWindow(ISCPDocumentation documentation)
        {
            this.commands = documentation.Commands;

            this.Border = new Border() { BorderStyle = BorderStyle.None };

            var menu = new MenuBar(new MenuBarItem[] {
                new MenuBarItem ("_File", new MenuItem [] {
                    new MenuItem ("_New", "Creates new file", null),
                    //new MenuItem ("_Close", "", Terminal.Gui.Application.RequestStop),
                    new MenuItem ("_Quit", "", null)
                })
            });
            this.Add(menu);

            FrameView modelFrameView = new FrameView()
            {
                Title = "Models",
                X = 1,
                Y = 1,
                Width = Dim.Sized(20),
                Height = Dim.Fill(0),

            };

            FrameView zoneFrameView = new FrameView()
            {
                Title = "Zones",
                X = Pos.Right(modelFrameView),
                Y = 1,
                Width = Dim.Sized(12),
                Height = Dim.Fill(0),

            };

            FrameView commandFrameView = new FrameView()
            {
                Title = "Commands",
                X = Pos.Right(zoneFrameView),
                Y = 1,
                Width = Dim.Sized(10),
                Height = Dim.Fill(0),

            };

            FrameView descriptionFrameView = new FrameView()
            {
                Title = "Description",
                X = Pos.Right(commandFrameView),
                Y = 1,
                Width = Dim.Fill(0),
                Height = Dim.Sized(3),

            };

            valuesFrameView = new FrameView()
            {
                Title = "Values",
                X = Pos.Right(commandFrameView),
                Y = Pos.Bottom(descriptionFrameView),
                Width = Dim.Fill(0),
                Height = Dim.Fill(0),

            };

            valuesScrollView = new ScrollView()
            {
                //Title = "Values",
                X = 0,
                Y = 0,
                Width = Dim.Fill(0),
                Height = Dim.Fill(0),
                ShowVerticalScrollIndicator = true,
                ContentSize = new Size(400, 300),
            };
            valuesFrameView.Add(valuesScrollView);

            modelListView = new ListView()
            {
                X = 1,
                Y = 0,
                Width = Dim.Fill(0),
                Height = Dim.Fill(0)
            };

            modelFrameView.Add(modelListView);
            modelListView.SelectedItemChanged += ModelListView_SelectedItemChanged;
            modelListView.SetSource(documentation.Models);

            zoneListView = new ListView()
            {
                Text = "Zones",
                X = 1,
                Y = 0,
                Width = Dim.Fill(0),
                Height = Dim.Fill(0)
                //Border = new Border() { BorderStyle = BorderStyle.Single, BorderThickness = new Thickness(1) }
            };
            zoneFrameView.Add(zoneListView);
            zoneListView.SelectedItemChanged += ZoneListView_SelectedItemChanged;

            commandListView = new ListView()
            {
                Text = "Commands",
                X = 1,
                Y = 0,
                Width = Dim.Fill(0),
                Height = Dim.Fill(0),
                Border = new Border() { BorderStyle = BorderStyle.Single, BorderThickness = new Thickness(1) }
            };
            commandListView.SelectedItemChanged += CommandListView_SelectedItemChanged;
            commandFrameView.Add(commandListView);

            commandDescriptionLabel = new Label("")
            {
                X = 1,
                Width = Dim.Fill(0),
            };
            descriptionFrameView.Add(commandDescriptionLabel);

            this.Add(modelFrameView);
            this.Add(zoneFrameView);
            this.Add(commandFrameView);
            this.Add(descriptionFrameView);
            this.Add(valuesFrameView);


            //Simulate selecting the first item in models to start the event chain.
            modelListView.OnSelectedChanged();
        }

        private void ModelListView_SelectedItemChanged(ListViewItemEventArgs obj)
        {
            selectedModel = obj.Value.ToString();
            zoneListView.SetSource(commands.Where(x => x.Values2.Any(y => y.SupportedDevices.Contains(selectedModel)))
                .Select(x => x.Zone).Distinct<string>().ToList());
            zoneListView.OnSelectedChanged();
        }
        private void ZoneListView_SelectedItemChanged(ListViewItemEventArgs obj)
        {
            selectedZone = obj.Value.ToString();

            commandListView.SetSource(commands.Where(x => x.Values2.Any(y => y.SupportedDevices.Contains(selectedModel))
                && x.Zone == selectedZone
                ).Select(x => x.Name).Distinct<string>().ToList());
            commandListView.OnSelectedChanged();
        }

        private void CommandListView_SelectedItemChanged(ListViewItemEventArgs obj)
        {
            selectedCommand = obj.Value.ToString();
            ISCPCommandDocumentation command = commands.Single(x => x.Values2.Any(y => y.SupportedDevices.Contains(selectedModel))
                && x.Zone == selectedZone
                && x.Name == selectedCommand);

            commandDescriptionLabel.Text = command.Description;

            valuesScrollView.RemoveAll();

            //int i = 0;
            bool first = true;
            foreach (ISCPCommandValueDocumentation value in command.Values2.Where(y => y.SupportedDevices.Contains(selectedModel)))
            {
                Label descriptionLabel = new Label()
                {
                    Text = value.Description,
                    Width = Dim.Fill(1),
                    AutoSize = true
                };
                FrameView valueFrame = new FrameView()
                {
                    Title = value.Name[0],
                    Y = first ? 0 : Pos.Bottom(valuesScrollView.Subviews[0].Subviews.Last()),
                    Width = Dim.Fill(1) ,
                    Height = descriptionLabel.Bounds.Height + 2,
                    AutoSize = true
                };
                valueFrame.Add(descriptionLabel);
                valuesScrollView.Add(valueFrame);
              
                first = false;
            }



            valuesScrollView.ContentSize = new Size(
                valuesFrameView.Bounds.Width == 0 ? 200 : valuesFrameView.Bounds.Width,
                valuesScrollView.Subviews[0].Subviews.Sum(x => x.Bounds.Height)
            );

            //valuesFrameView.Height = Dim.Fill(1);
        }

    }
}
