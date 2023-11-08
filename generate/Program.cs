using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using System.CodeDom.Compiler;
using System.Net.Http.Headers;
using onkyo;
//using static System.Net.Mime.MediaTypeNames;
//using System.Reflection.Emit;
using Terminal.Gui;
using Eiscp.Core;
using generate;
using Eiscp.Core.Models;

class Program
{
    public static void Main(string[] args)
    {
        ISCPDocumentation iSCPDocumentation = ISCPDocumentationGenerator.Parse("./ISCP_AVR_146.xlsx");


        Application.Init();

        DocumentationWindow documentation = new DocumentationWindow(iSCPDocumentation);

        
        Application.Top.Add(documentation);
        Application.Run();
        Application.Shutdown();
    }
}


