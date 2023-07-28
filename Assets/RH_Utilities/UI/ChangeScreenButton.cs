using UnityEngine;
using static RH_Utilities.UI.Screen;

namespace RH_Utilities.UI
{
    public class ChangeScreenButton : BaseActionButton
    {
        [SerializeField] private string _screen;
        [SerializeField] private bool _additive;
    
        protected override void PerformOnClick() => 
            Show(_screen, !_additive);
    }
}