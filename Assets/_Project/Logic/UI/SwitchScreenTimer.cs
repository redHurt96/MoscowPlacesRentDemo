using UnityEngine;
using static RH_Utilities.UI.Screen;
using static UnityEngine.Time;

namespace _Project.Logic.UI
{
    public class SwitchScreenTimer : MonoBehaviour
    {
        public float CurrentTime { get; private set; }
        
        [SerializeField] private float _timeToScreensaver;
        [SerializeField] private string _screenToSwitch;

        private void OnEnable() => 
            CurrentTime = _timeToScreensaver;

        private void Update()
        {
            CurrentTime -= deltaTime;
            
            if (CurrentTime <= 0f)
                Show(_screenToSwitch);
        }
    }
}