using System;
using RH_Utilities.Attributes;
using RH_Utilities.UI;
using UnityEngine;
using static UnityEngine.Application;
using static UnityEngine.Time;

namespace _Project.Logic.UI
{
    public class ExitButton : BaseActionButton
    {
        [SerializeField, ReadOnly] private float _currentDelay;
        [SerializeField, ReadOnly] private int _tapCount;
        
        private readonly float _delay = 1f;
        private readonly int _tapToQuitCount = 5;

        private void Update()
        {
            if (_tapCount > 0)
                _currentDelay += deltaTime;

            if (_currentDelay > _delay)
            {
                _tapCount = 0;
                _currentDelay = 0f;
            }
        }

        protected override void PerformOnClick()
        {
            _tapCount++;
            _currentDelay = 0f;

            if (_tapCount == _tapToQuitCount)
                Quit();
        }
    }
}