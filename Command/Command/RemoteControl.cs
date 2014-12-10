using System;
using System.Collections.Generic;
using System.Linq;
using Command.Commands;

namespace Command
{
    public class RemoteControl
    {
        private readonly Dictionary<int, ICommand> _devices;

        public RemoteControl()
        {
            _devices = new Dictionary<int, ICommand>();
        }

        public void AddDevice(int id, ICommand device)
        {
            _devices[id] = device;
        }

        public void RunCommand(int id)
        {
            if (_devices.ContainsKey(id))
            {
                _devices[id].Execute();
            }
        }

        public void RemoveDevice(ICommand device)
        {
            if (_devices.ContainsValue(device))
            {
                var removeDevice = _devices.FirstOrDefault(x => x.Value == device);
                _devices.Remove(removeDevice.Key);
            }
        }

        /// <summary>
        /// Отображение списка привязанных к кнопкам устройств
        /// </summary>
        public void PrintMenu()
        {
            foreach (var command in _devices)
            {
                Console.WriteLine("{0}: \t {1}", command.Key, command.Value);
            }
            Console.WriteLine("0: \t ВЫХОД");
        }
    }
}
