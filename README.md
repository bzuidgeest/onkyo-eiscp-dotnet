Onkyo ISCP Control, .NET version
---------------------------------

This is a rebuild and clean up of the .NET [.Net version](https://github.com/miracle2k/onkyo-eiscp-net).

There are three projects in this solution

- ISCPDocumentationGenerator
This parses the documentation excel file from onkyo and shows the result in a nice console UI.
It also has an export command to write the documentation out as an object in C# code. This is mostly for the EISCP.Core library for validation and parsing
- EISCP.core
The main library contains a client for using the iscp protocol over network or direct serial connection. Since I don't have a Serially connected device the serial version is untested
- ISCPDemoClient
A Small client to test some things out. (to be build)