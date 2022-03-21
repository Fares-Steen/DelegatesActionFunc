namespace FullActionExample;

public class EventsHandler
{
    public Action<MessageEvent> events = null;
    public void InvokeHandler(MessageEvent message)
    {
        events.Invoke(message);
    }


}