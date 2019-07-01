using System;
using Paramore.Brighter;

namespace HelloWorldBrighter
{
    class Program
    {
        static void Main(string[] args)
        {
            var registry = new SubscriberRegistry();
            registry.Register<GreetingCommand, GreetingCommandHandler>();

            var builder = CommandProcessorBuilder.With()
                .Handlers(new HandlerConfiguration(
                    subscriberRegistry: registry,
                    handlerFactory: new SimpleHandlerFactory()
                ))
                .DefaultPolicy()
                .NoTaskQueues()
                .RequestContextFactory(new InMemoryRequestContextFactory());

            var commandProcessor = builder.Build();
            commandProcessor.Send(new GreetingCommand("Alfonso"));

            Console.ReadKey();
        }
    }
}