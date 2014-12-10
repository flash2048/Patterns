namespace State
{
    class Program
    {
        static void Main()
        {
            var printer = new Printer();
            printer.PowerOn();
            printer.PrintDocument();
            printer.AddPater(3);
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PrintDocument();
            printer.PowerOff();
        }
    }
}
