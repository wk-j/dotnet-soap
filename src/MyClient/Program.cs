// See https://aka.ms/new-console-template for more information


var sample = new ServiceReference.SampleServiceClient();
var x = await sample.PingAsync("wk");

Console.WriteLine(x);
