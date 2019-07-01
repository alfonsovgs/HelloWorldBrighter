using Paramore.Brighter;
using System;

namespace HelloWorldBrighter
{
    public class SimpleHandlerFactory : IAmAHandlerFactory
    {
        public IHandleRequests Create(Type handlerType)
        {
            return new GreetingCommandHandler();
        }

        public void Release(IHandleRequests handler)
        {
        }
    }
}