// See https://aka.ms/new-console-template for more information


using static ServiceReference.SampleServiceClient;

var endpint = new EndpointConfiguration();

var sample = new ServiceReference.SampleServiceClient();
var x = await sample.PingAsync("wk");

Console.WriteLine(x);
