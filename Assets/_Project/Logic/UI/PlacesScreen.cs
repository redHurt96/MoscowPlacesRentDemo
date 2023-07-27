using _Project.Logic.Domain;
using UnityEngine;
using static RH_Utilities.UI.Screen;

namespace _Project.Logic.UI
{
    public class PlacesScreen : MonoBehaviour
    {
        [SerializeField] private EventsConfig _eventsConfig;
        
        private string _eventName;
        private GameObject _view;

        private void OnDisable()
        {
            if (_view != null)
                Destroy(_view);
        }

        public void Select(string eventName)
        {
            _eventName = eventName;
            _view = Instantiate(_eventsConfig.PlacesFor(_eventName), transform);
            _view.transform.SetSiblingIndex(0);
        }

        public void Select(int placeNumber)
        {
            if (_eventsConfig.IsPlaceCorrect(placeNumber, _eventName))
            {
                FindObjectOfType<GoodChoiceScreen>(true)
                    .SelectFor(_eventName);
                Show("Good Choice Screen");
            }
            else
            {
                Show("Bad Choice Screen", false);
            }
        }
    }
}