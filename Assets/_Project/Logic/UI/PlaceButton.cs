using RH_Utilities.UI;
using UnityEngine;

namespace _Project.Logic.UI
{
    public class PlaceButton : BaseActionButton
    {
        [SerializeField] private int _index;

        protected override void PerformOnClick() =>
            FindObjectOfType<PlacesScreen>()
                .Select(_index);
    }
}