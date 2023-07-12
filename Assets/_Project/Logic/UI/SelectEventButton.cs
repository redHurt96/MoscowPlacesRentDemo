using _Project.Logic.Domain;
using RH_Utilities.UI;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class SelectEventButton : BaseActionButton
    {
        [SerializeField] private Text _name;
        [SerializeField] private EventModel _event;

        protected override void PerformOnStart() => 
            _name.text = _event.Name;

        protected override void PerformOnClick()
        {
            FindObjectOfType<PlacesScreen>(true)
                .Select(_event);
            FindObjectOfType<EventScreen>(true)
                .Select(_event);
        }
    }
}