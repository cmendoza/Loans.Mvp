namespace Loans.Mvp.Infrastructure;

public class EventArgs<T> : EventArgs where T : class
{
    public T Data { get; private set; }

    public EventArgs(T data) => Data = data;
}
