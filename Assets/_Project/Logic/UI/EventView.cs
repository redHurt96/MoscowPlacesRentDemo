using _Project.Logic.Domain;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Logic.UI
{
    public class EventView : MonoBehaviour
    {
        [SerializeField] private Text _name;
        [SerializeField] private Text _description;
        
        public void Setup(EventModel eventModel)
        {
            _name.text = eventModel.Name;
            _description.text = eventModel.Description;
        }
    }
}