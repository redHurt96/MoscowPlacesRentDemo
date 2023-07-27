using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    internal class GoodChoiceScreen : MonoBehaviour
    {
        [SerializeField] private EventsConfig _config;
        [SerializeField] private Image _content;

        public void SelectFor(string eventName) => 
            _content.sprite = _config.GoodResultFor(eventName);
    }
}