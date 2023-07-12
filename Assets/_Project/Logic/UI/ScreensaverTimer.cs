using RH_Utilities.Attributes;
using UnityEngine;
using static RH_Utilities.UI.Screen;
using static UnityEngine.Time;

namespace _Project.Logic.UI
{
    public class ScreensaverTimer : MonoBehaviour
    {
        [SerializeField] private float _timeToScreensaver;
        [SerializeField, ReadOnly] private float _currentTime;

        private void OnEnable() => 
            _currentTime = _timeToScreensaver;

        private void Update()
        {
            _currentTime -= deltaTime;
            
            if (_currentTime <= 0f)
                Show("ScreenSaver");
        }
    }
}