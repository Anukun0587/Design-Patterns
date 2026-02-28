using DamageSystem.Models;
using DamageSystem.Handler;

namespace DamageSystem.Handler
{
    public abstract class DamageHandlerBase : IDamageHandler
    {
        private IDamageHandler? nextHandler;

        public IDamageHandler SetNext(IDamageHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public void Handle(DamageContext ctx)
        {
            Process(ctx);
            nextHandler?.Handle(ctx);
        }

        protected abstract void Process(DamageContext ctx);
    }
}