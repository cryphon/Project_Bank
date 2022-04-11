namespace Assignment1
{
    internal interface IStack
    {
        void Push(int value);
        int Pop();
        bool Contains(int value);
        int Count();
        bool IsEmpty();
    }
}