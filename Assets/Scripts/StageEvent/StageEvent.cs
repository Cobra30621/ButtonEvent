using System;
using UnityEngine;

namespace StageEvent
{
    [Serializable]
    public class StageEvent
    {
        public string EventName;
        public Sprite image;

        public ActionParameter ActionParameter;
    }
}