using DamageSystem.Models;

namespace DamageSystem.Handler
{
    public interface IDamageHandler
    {
        IDamageHandler SetNext(IDamageHandler handler);
        void Handle(DamageContext ctx);
    }
}