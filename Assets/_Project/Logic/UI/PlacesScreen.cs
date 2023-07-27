using _Project.Logic.Domain;
using UnityEngine;
using static RH_Utilities.UI.Screen;

namespace _Project.Logic.UI
{
    public class PlacesScreen : MonoBehaviour
    {
        [SerializeField] private EventsConfig _eventsConfig;
        [SerializeField] private SwitchScreenTimer _timer;
        [SerializeField] private PlaceButton[] _placeButtons;
        
        private string _eventName;

        public void Select(string eventName)
        {
            _eventName = eventName;
            Sprite[] placeConfigs = _eventsConfig.PlacesFor(_eventName);

            for (int i = 0; i < _placeButtons.Length; i++) 
                _placeButtons[i].Setup(placeConfigs[i]);
        }

        public void Select(int placeNumber)
        {
            if (_eventsConfig.IsPlaceCorrect(placeNumber, _eventName))
            {
                FindObjectOfType<GoodChoiceScreen>(true)
                    .SelectFor(_eventName, _timer.CurrentTime);
                Show("Good Choice Screen");
            }
            else
            {
                Show("Bad Choice Screen", false);
            }
        }
    }
}