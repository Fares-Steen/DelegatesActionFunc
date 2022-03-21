// See https://aka.ms/new-console-template for more information

using FullActionExample;

EventsHandler eventsHandler=new EventsHandler();

for (int i = 0; i < 10; i++)
{
    eventsHandler.InvokeHandler(new MessageEvent
    {
        Id = i,
        Message = "fares is here now "
    });
}
eventsHandler.events += HandleAMessage;
void HandleAMessage(MessageEvent messageEvent)
{
    Console.WriteLine($"Id: {messageEvent.Id}, message: {messageEvent}");
}