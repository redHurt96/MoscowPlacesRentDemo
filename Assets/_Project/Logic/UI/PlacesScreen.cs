using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;
using static RH_Utilities.UI.Screen;

namespace _Project.Logic.UI
{
    public class PlacesScreen : MonoBehaviour
    {
        [SerializeField] private EventView _eventView;
        [SerializeField] private PlaceView _placeView;
        [SerializeField] private Button _confirmButton;
        
        private EventModel _eventModel;
        private PlaceModel _placeModel;

        private void Start() => 
            _confirmButton.onClick.AddListener(OpenChoiceScreen);

        private void OnDestroy() => 
            _confirmButton.onClick.RemoveListener(OpenChoiceScreen);

        private void OnDisable()
        {
            _confirmButton.interactable = false;
            _eventModel = null;
            _placeModel = null;
        }

        public void LookAt(PlaceModel place)
        {
            _placeModel = place;
            _placeView.Show(place);
            _confirmButton.interactable = true;
        }

        public void Select(EventModel eventModel)
        {
            _eventModel = eventModel;
            _eventView.Setup(eventModel);
        }

        private void OpenChoiceScreen()
        {
            FindObjectOfType<ChoiceScreen>(true)
                .SetupComparison(_eventModel, _placeModel);
            Show("Choice Screen");
        }
    }
}