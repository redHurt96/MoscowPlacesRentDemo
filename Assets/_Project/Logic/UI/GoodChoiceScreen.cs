using System;
using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    internal class GoodChoiceScreen : MonoBehaviour
    {
        [SerializeField] private EventsConfig _config;
        
        private GameObject _view;

        private void OnDisable()
        {
            if (_view != null)
                Destroy(_view);
        }

        public void SelectFor(string eventName, float timerCurrentTime)
        {
            _view = Instantiate(_config.GoodResultFor(eventName), transform);
            GetComponentInChildren<Text>().text = timerCurrentTime.ToString("F0");
        }
    }
}