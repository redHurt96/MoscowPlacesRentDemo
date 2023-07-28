using System;
using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;
using static RH_Utilities.UI.Screen;

namespace _Project.Logic.UI
{
    public class PlacesScreen : MonoBehaviour
    {
        [SerializeField] private EventsConfig _eventsConfig;
        [SerializeField] private SwitchScreenTimer _timer;
        [SerializeField] private PlaceButton[] _placeButtons;
        [SerializeField] private Button _briefButton;
        [SerializeField] private BriefScreen _briefScreen;
        
        private string _eventName;

        private void Start() => 
            _briefButton.onClick.AddListener(ShowBriefScreen);
        
        private void OnDestroy() => 
            _briefButton.onClick.RemoveListener(ShowBriefScreen);

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

        private void ShowBriefScreen()
        {
            _briefScreen.Show(_eventsConfig.ShortDescriptionFor(_eventName));
            Show("Brief Screen", false);
        }
    }
}