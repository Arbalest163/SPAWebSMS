public interface ISenderService<T> where T : class
{
    void Send(T request);
}
