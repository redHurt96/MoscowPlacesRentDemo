using RH_Utilities.UI;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class PlaceButton : BaseActionButton
    {
        [SerializeField] private Image _image;
        [SerializeField] private int _index;

        protected override void PerformOnClick() =>
            FindObjectOfType<PlacesScreen>()
                .Select(_index);

        public void Setup(Sprite sprite) => 
            _image.sprite = sprite;
    }
}