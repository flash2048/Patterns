namespace Facade.Microwave
{
    class Microwave
    {
        private readonly Drive _drive;
        private readonly Power _power;
        private readonly Notification _notification;

        public Microwave(Drive drive, Power power, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
        }

        public void Defrost()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 1000;
            _drive.TurlRight();
            _drive.TurlRight();
            _power.MicrowavePower = 500;
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.MicrowavePower = 200;
            _drive.TurlRight();
            _drive.TurlRight();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }

        public void Heating()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 350;
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }
    }
}
