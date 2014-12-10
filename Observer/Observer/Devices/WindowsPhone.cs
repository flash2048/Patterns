using System;

namespace Observer.Devices
{
    class WindowsPhone:IObserver
    {
        private String _name;
        private String _message;

        public WindowsPhone(String name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine("WP device {0}. Message is received: {1}", _name,_message );
        }

        public void Update(object sender, String message)
        {
            _message = message;
            Display();
        }
    }
}
