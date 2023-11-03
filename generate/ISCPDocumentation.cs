using Eiscp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generate
{
    public class ISCPDocumentation
    {
        public List<ISCPCommandDocumentation> Commands { get; private set; } = new List<ISCPCommandDocumentation>();

        public Version Version { get; private set; } = new Version();

        public string[] Models { get; private set; } = { };


        public ISCPDocumentation(List<ISCPCommandDocumentation> commands, Version version)  
        {
            this.Commands = commands;
            this.Version = version;
        }

        public ISCPDocumentation(Version version)
        {
            this.Version = version;
        }

        public ISCPDocumentation()
        {

        }

        public void AddModels(string[] models)
        {

            Models = models.Union(models).ToArray();
        }
    }
}
