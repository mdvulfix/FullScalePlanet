
namespace Core
{

    public class SessionDefault : Session
    {
        
        public override void SetControls()
        {
            AddControl<ControlScene>(new ControlSceneDefault(this));
            AddControl<ControlUpdate>(new ControlUpdateDefault(this));

        
        
        }

    }
}