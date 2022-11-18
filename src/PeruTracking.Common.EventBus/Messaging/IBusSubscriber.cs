namespace PeruTracking.Common.EventBus.Messaging
{
    using MediatR;

    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeEvent<TEvent>(string @namespace = null) where TEvent : IEvent, IRequest;
    }
}
