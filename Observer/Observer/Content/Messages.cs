using System;
using System.Linq;


namespace Observer.Content
{

    public delegate void MessagesContentChangeEventHandler(object sender, String message);

    public class Messages
    {
        public event MessagesContentChangeEventHandler ContentChanged;

        private readonly Random _rand;

        public Messages()
        {
            _rand = new Random();
        }

        private String GetMessage()
        {
            var messages = new string[] {"Сообщение первое", "Тестирование Push уведомлений", "Срочная новость", "Оповещение!!!"};
            return messages[_rand.Next(messages.Count())];
        }


        public void MessageAvailable()
        {
            var message = GetMessage();
          
            if (ContentChanged != null)
            {
                ContentChanged(this, message);
            }
        }
    }
}
