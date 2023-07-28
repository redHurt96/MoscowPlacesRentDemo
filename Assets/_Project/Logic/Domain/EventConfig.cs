using System;
using UnityEngine;

namespace _Project.Logic.Domain
{
    [Serializable]
    public class EventConfig
    {
        public string EventName;
        public Sprite Description;
        public Sprite ShortDescription;
        public Sprite[] Places;
        public int[] CorrectPlaces;
        public GameObject GoodResult;
    }
}