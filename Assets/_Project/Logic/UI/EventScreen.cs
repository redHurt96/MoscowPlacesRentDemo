using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;
using Screen = RH_Utilities.UI.Screen;

namespace _Project.Logic.UI
{
    public class EventScreen : MonoBehaviour
    {
        [SerializeField] private EventsConfig _eventsConfig;
        [SerializeField] private Image _content;
        [SerializeField] private Button _confirmButton;
        
        private string _eventName;

        public void Select(string eventName)
        {
            _eventName = eventName;
            _content.sprite = _eventsConfig.DescriptionFor(eventName);
            _confirmButton.onClick.RemoveAllListeners();
            _confirmButton.onClick.AddListener(() =>
            {
                FindObjectOfType<PlacesScreen>(true)
                    .Select(_eventName);
                Screen.Show("Places Screen");
            });
        }
    }
}