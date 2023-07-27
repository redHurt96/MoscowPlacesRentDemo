using System;
using UnityEngine;

namespace _Project.Logic.Domain
{
    [Serializable]
    public class EventConfig
    {
        public string EventName;
        public Sprite Description;
        public GameObject Places;
        public int[] CorrectPlaces;
        public Sprite GoodResult;
    }
}