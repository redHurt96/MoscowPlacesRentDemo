using System.Linq;
using UnityEngine;

namespace _Project.Logic.Domain
{
    [CreateAssetMenu(menuName = "Create EventsConfig", fileName = "EventsConfig", order = 0)]
    public class EventsConfig : ScriptableObject
    {
        [SerializeField] private EventConfig[] _events;

        public Sprite DescriptionFor(string eventName) =>
            _events
                .First(x => x.EventName == eventName)
                .Description;

        public bool IsPlaceCorrect(int placeNumber, string eventName) =>
            _events
                .First(x => x.EventName == eventName)
                .CorrectPlaces
                .Contains(placeNumber);

        public GameObject PlacesFor(string eventName) =>
            _events
                .First(x => x.EventName == eventName)
                .Places;

        public Sprite GoodResultFor(string eventName) =>
            _events
                .First(x => x.EventName == eventName)
                .GoodResult;
    }
}