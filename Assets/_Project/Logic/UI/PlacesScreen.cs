using _Project.Logic.Domain;
using UnityEngine;
using static RH_Utilities.UI.Screen;

namespace _Project.Logic.UI
{
    public class PlacesScreen : MonoBehaviour
    {
        private EventModel _eventModel;
        private PlaceModel _placeModel;

        private void OnDisable()
        {
            _eventModel = null;
            _placeModel = null;
        }

        public void Select(PlaceModel place)
        {
            _placeModel = place;
            FindObjectOfType<ChoiceScreen>(true)
                .SetupComparison(_eventModel, _placeModel);
            Show("Choice Screen");
        }

        public void Select(EventModel eventModel) => 
            _eventModel = eventModel;
    }
}