using System;

namespace Observer.Devices
{
    class AndroidPhone:IObserver
    {
        private readonly String _name;
        private String _message;

        public AndroidPhone(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine("Android device {0}.  Message is received: {1}", _name, _message);
        }

        public void Update(object sender, string message)
        {
            _message = message;
            Display();
        }
    }
}
