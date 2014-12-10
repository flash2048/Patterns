namespace State.States
{
    interface IState
    {
        void On();
        void Off();
        void Print();
        void AddPaper(int count);
    }
}
