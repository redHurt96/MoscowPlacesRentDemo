using RH_Utilities.UI;

namespace _Project.Logic.UI
{
    public class CloseScreenButton : BaseActionButton
    {
        protected override void PerformOnClick() =>
            transform.parent.gameObject.SetActive(false);
    }
}