using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private Text _label;
        [SerializeField] private Image _clock;
        
        private SwitchScreenTimer _timer;

        private void Start() => 
            _timer = GetComponentInParent<SwitchScreenTimer>();

        private void Update()
        {
            _label.text = _timer.CurrentTime < 10 
                ? $"00:0{_timer.CurrentTime:F0}" 
                : $"00:{_timer.CurrentTime:F0}";

            _clock.fillAmount = _timer.Progress;
        }
    }
}