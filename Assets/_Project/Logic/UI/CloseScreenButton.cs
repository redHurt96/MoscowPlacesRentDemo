using RH_Utilities.UI;
using UnityEngine;

namespace _Project.Logic.UI
{
    public class CloseScreenButton : BaseActionButton
    {
        [SerializeField] private GameObject _toClose;
        
        protected override void PerformOnClick() =>
            _toClose.SetActive(false);
    }
}