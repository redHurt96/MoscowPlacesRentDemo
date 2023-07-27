using UnityEngine;
using static RH_Utilities.UI.Screen;
using static UnityEngine.Time;

namespace _Project.Logic.UI
{
    public class SwitchScreenTimer : MonoBehaviour
    {
        public float CurrentTime => _timeToScreensaver - _leftTime;
        public float Progress => CurrentTime / _timeToScreensaver;

        [SerializeField] private float _timeToScreensaver;
        [SerializeField] private string _screenToSwitch;

        private float _leftTime;
        
        private void OnEnable() => 
            _leftTime = _timeToScreensaver;

        private void Update()
        {
            _leftTime -= deltaTime;
            
            if (_leftTime <= 0f)
                Show(_screenToSwitch);
        }
    }
}