using _Project.Logic.Domain;
using UnityEngine;

namespace _Project.Logic.UI
{
    public class EventScreen : MonoBehaviour
    {
        [SerializeField] private EventView _eventView;
        
        public void Select(EventModel eventModel) => 
            _eventView.Setup(eventModel);
    }
}