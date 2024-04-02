using System.Collections.Generic;
using UnityEngine;

namespace StageEvent
{
    [CreateAssetMenu(fileName = "Event Data", menuName = "Event Data", order = 1)]
    public class StageEventData : ScriptableObject
    {
        public List<StageEvent> StageEvents;
    }
}