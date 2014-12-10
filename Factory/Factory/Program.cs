using Factory.GUI;
namespace Factory
{
    class Program
    {
        static void Main()
        {
            var client = new Client.Client();

            var standartWindow = client.CreateWindow(new StandartGUIFactory());
            var designWindow = client.CreateWindow(new DesignGUIFactory());

            client.Print(standartWindow);
            client.Print(designWindow);
        }
    }
}
