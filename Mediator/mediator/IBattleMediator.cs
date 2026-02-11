using Mediator.colleagues;

namespace Mediator.mediator
{
    public interface IBattleMediator
    {
        public void Notify(GameUnit sender, string ev, int damage);
    }
}