using State.States;
namespace State
{
    class Printer
    {
        private IState _state;
        private int _countPaper;

        public PaperOffState PaperOffState { get; private set; }
        public PowerOffState PowerOffState { get; private set; }
        public PrintState PrintState { get; private set; }
        public WaitingState WaitingState { get; private set; }
        public int CountPaper {
            get { return _countPaper; }
        }

        public Printer()
        {
            PowerOffState = new PowerOffState(this);
            PaperOffState = new PaperOffState(this);
            PrintState = new PrintState(this);
            WaitingState = new WaitingState(this);
            _state = WaitingState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void PrintDocument()
        {
            _state.Print();
        }

        public void PowerOff()
        {
            _state.Off();
        }
        public void PowerOn()
        {
            _state.On();
        }

        public void AddPater(int count)
        {
            _countPaper += count;
        }
    }
}
