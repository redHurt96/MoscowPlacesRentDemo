using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class BriefScreen : MonoBehaviour
    {
        [SerializeField] private Image _image;

        public void Show(Sprite shortDescriptionFor) => 
            _image.sprite = shortDescriptionFor;
    }
}