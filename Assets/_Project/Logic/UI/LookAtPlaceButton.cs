using _Project.Logic.Domain;
using RH_Utilities.UI;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class LookAtPlaceButton : BaseActionButton
    {
        [SerializeField] private PlaceModel _placeModel;
        [SerializeField] private Text _name;

        protected override void PerformOnStart() => 
            _name.text = _placeModel.Name;

        protected override void PerformOnClick() =>
            FindObjectOfType<PlacesScreen>(true)
                .LookAt(_placeModel);
    }
}