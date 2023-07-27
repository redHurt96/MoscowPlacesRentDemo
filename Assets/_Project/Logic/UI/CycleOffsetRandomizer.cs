using UnityEngine;
using static UnityEngine.Random;

namespace _Project.Logic.UI
{
    [RequireComponent(typeof(Animator))]
    public class CycleOffsetRandomizer : MonoBehaviour
    {
        private void OnEnable() =>
            GetComponent<Animator>()
                .SetFloat("CycleOffset", Range(0f, 1f));
    }
}