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
        public ListView commandListView;

        private List<ISCPCommandDocumentation> commands;
        public DocumentationWindow(List<ISCPCommandDocumentation> commands)
        {
            this.commands = commands;

            
            FrameView zoneFrameView = new FrameView()
            {
                Title = "Zones",
                X = 0,
                Y = 0,
                Width = Dim.Sized(10),
                Height = Dim.Fill(0),
                
            };
            ListView zoneListView = new ListView()
            {
                Text = "Zones",
                X = 0,
                Y = 0,
                Width = Dim.Fill(0),
                Height = Dim.Fill(0)
                //Border = new Border() { BorderStyle = BorderStyle.Single, BorderThickness = new Thickness(1) }
            };
            zoneFrameView.Add(zoneListView);

            commandListView = new ListView()
            {
                Text = "Commands",
                X = 10,
                Y = 0,
                Width = Dim.Sized(10),
                Height = Dim.Fill(10),
                Border = new Border() { BorderStyle = BorderStyle.Single, BorderThickness = new Thickness(1) }
            };

            zoneListView.SelectedItemChanged += ZoneListView_SelectedItemChanged;
            zoneListView.SetSource(commands.Select(x => x.Zone).Distinct<string>().ToList());
            
            this.Add(zoneFrameView);
            this.Add(commandListView);



        }

        private void ZoneListView_SelectedItemChanged(ListViewItemEventArgs obj)
        {
            commandListView.SetSource(commands.Where(x => x.Zone == obj.Value).Select(y => y.Name).ToList());
        }
    }
}
