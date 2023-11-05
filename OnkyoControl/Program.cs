// See https://aka.ms/new-console-template for more information
using Eiscp.Core;
using Eiscp.Core.Models;

Console.WriteLine("Hello, World!");

Console.WriteLine("Looking for receivers...");
List<ReceiverInfo> receivers = NetworkUtils.Discover(1);

if (receivers.Count == 0)
{
    Console.WriteLine("No receivers found!");
}
else
{
    Console.WriteLine("Found: ");
    foreach (ReceiverInfo receiver in receivers)
    {
        Console.WriteLine($"Model: {receiver.ModelName}\r\n\tEndpoint: {receiver.IPEndPoint.Address.ToString()}:{receiver.Port}\r\n\tIdentifier: {receiver.Identifier}\r\n\tAreaCode: {receiver.AreaCode}\r\n\tHostname: {receiver.Hostname}\r\n");

    }
}

Console.WriteLine("Opening connection to first receiver...");
EISCPClient2 client = new EISCPClient2(receivers[0]);
client.Connect();

while(client.Connected == false)
{
    Console.Write(".");
}
Console.WriteLine("Connected");


//client.SendCommand("main.power:on");
//while (true)
//{
//    client.SendCommand("PWRQSTN");
//    Thread.Sleep(1000);
//}

for (int i = 0; i < 10; i++)
{
    client.SendCommand("PWRQSTN");
    Thread.Sleep(1000);
}
Console.WriteLine("Shutting down.");
client.Disconnect();

Console.ReadLine(); 