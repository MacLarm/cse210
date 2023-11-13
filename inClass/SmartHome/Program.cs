// See https://aka.ms/new-console-template for more information
Console.WriteLine();

SmartDevice test = new SmartDevice("tester");
test.TurnOn();
Thread.Sleep(4000);
test.CheckTime();
test.CheckStatus();
test.TurnOff();
test.CheckStatus();
