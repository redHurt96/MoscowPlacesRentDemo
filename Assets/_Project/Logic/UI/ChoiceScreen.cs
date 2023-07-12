using System;
using System.Collections;
using System.Linq;
using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    internal class ChoiceScreen : MonoBehaviour
    {
        [SerializeField] private Text _result;
        [SerializeField] private Comparison[] _comparisons;
        [SerializeField] private string _badComparisonTitle;
        
        public void SetupComparison(EventModel eventModel, PlaceModel placeModel)
        {
            // Comparison target = _comparisons.FirstOrDefault(x => x.EventName == eventModel.Name
            //                                                      && x.PlaceName == placeModel.Name);
            //
            // _result.text = target != null ? 
            //     target.Result : 
            //     _badComparisonTitle;
        }
    }
}