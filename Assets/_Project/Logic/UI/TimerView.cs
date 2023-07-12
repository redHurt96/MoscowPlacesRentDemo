using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private SwitchScreenTimer _timer;
        [SerializeField] private Text _label;

        private void Update() => 
            _label.text = _timer.CurrentTime.ToString("F0");
    }
}