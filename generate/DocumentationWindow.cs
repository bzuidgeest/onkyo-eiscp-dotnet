using Eiscp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace generate
{
    internal class DocumentationWindow : Toplevel
    {
        private ListView commandListView;
        private ListView zoneListView;
        private Label commandDescriptionLabel;

        private string selectedZone = "";
        private string selectedCommand = "";

        private List<ISCPCommandDocumentation> commands;
        public DocumentationWindow(List<ISCPCommandDocumentation> commands)
        {
            this.commands = commands;

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
                Width = Dim.Sized(12),
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
            FrameView valuesFrameView = new FrameView()
            {
                Title = "Values",
                X = Pos.Right(commandFrameView),
                Y = Pos.Bottom(descriptionFrameView),
                Width = Dim.Fill(0),
                Height = Dim.Fill(0),

            };

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

            zoneListView.SelectedItemChanged += ZoneListView_SelectedItemChanged;
            zoneListView.SetSource(commands.Select(x => x.Zone).Distinct<string>().ToList());

            this.Add(modelFrameView);
            this.Add(zoneFrameView);
            this.Add(commandFrameView);
            this.Add(descriptionFrameView);
            this.Add(valuesFrameView);

            // Set first zone selected.
            zoneListView.OnSelectedChanged(); //.SelectedItem = 0;
        }

        private void CommandListView_SelectedItemChanged(ListViewItemEventArgs obj)
        {
            selectedCommand = obj.Value.ToString();
            commandDescriptionLabel.Text = commands.First(x => x.Zone == selectedZone && x.Name == selectedCommand).Description;
        }

        private void ZoneListView_SelectedItemChanged(ListViewItemEventArgs obj)
        {
            selectedZone = obj.Value.ToString();
            commandListView.SetSource(commands.Where(x => x.Zone == selectedZone).Select(y => y.Name).ToList());
            commandListView.OnSelectedChanged();
        }
    }
}
