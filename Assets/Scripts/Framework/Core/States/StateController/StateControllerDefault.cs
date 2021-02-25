
namespace Core
{
    public class StateControllerDefault: StateController, IStateController
    {



        public override IState SetState<T>()
        {
            var state = base.SetState<T>();
            return state;

        }


    }
}

