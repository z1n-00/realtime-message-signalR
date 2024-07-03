namespace SignalR.Api
{
    public interface IChatClient
    {
        Task ReceivedMessage (string message);
    }
}
