using System;
using Paramore.Brighter;

namespace HelloWorldBrighter
{
    class GreetingCommandHandler : RequestHandler<GreetingCommand>
    {
        public override GreetingCommand Handle(GreetingCommand command)
        {
            Console.WriteLine("Hello {0}", command.Name);
            return base.Handle(command);
        }
    }
}