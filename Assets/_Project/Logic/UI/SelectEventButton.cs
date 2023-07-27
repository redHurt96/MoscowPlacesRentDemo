using RH_Utilities.UI;
using UnityEngine;

namespace _Project.Logic.UI
{
    public class SelectEventButton : BaseActionButton
    {
        [SerializeField] private string _eventName;

        protected override void PerformOnClick() =>
            FindObjectOfType<EventScreen>(true)
                .Select(_eventName);
    }
}