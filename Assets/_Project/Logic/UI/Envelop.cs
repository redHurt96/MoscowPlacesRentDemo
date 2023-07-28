using System.Collections;
using DG.Tweening;
using RH_Utilities.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.Vector3;
using Screen = RH_Utilities.UI.Screen;

namespace _Project.Logic.UI
{
    public class Envelop : BaseActionButton
    {
        [SerializeField] private int _closeSiblingIndex = 3;
        [SerializeField] private string _eventName;
        [SerializeField] private RectTransform _close;
        [SerializeField] private RectTransform _paper;

        private void OnEnable()
        {
            if (_close.GetSiblingIndex() != _closeSiblingIndex)
            {
                _close.SetSiblingIndex(_closeSiblingIndex);
                _close.localScale = one;
                _paper.localPosition = new(_paper.localPosition.x, 125, _paper.localPosition.z);
            }
        }

        protected override void PerformOnClick()
        {
            EventSystem eventSystem = EventSystem.current;
            eventSystem.enabled = false;

            _close
                .DOScaleY(-1f, 1f)
                .OnComplete(() =>
                {
                    _close.SetSiblingIndex(0);
                    _paper
                        .DOLocalMoveY(533f, 1f)
                        .OnComplete(() => StartCoroutine(ShowEventScreen(eventSystem)));
                });
        }

        private IEnumerator ShowEventScreen(EventSystem eventSystem)
        {
            yield return new WaitForSeconds(2f);
            
            eventSystem.enabled = true;
            FindObjectOfType<EventScreen>(true)
                .Select(_eventName);
            Screen.Show("Event Screen");
        }
    }
}