using System;
using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class PlaceView : MonoBehaviour
    {
        [SerializeField] private Text _name;
        [SerializeField] private Text _description;
        
        public void Show(PlaceModel placeModel)
        {
            _name.text = placeModel.Name;
            _description.text = placeModel.Description;
        }

        private void OnDisable()
        {
            _name.text = string.Empty;
            _description.text = string.Empty;
        }
    }
}