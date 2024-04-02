using System.Collections.Generic;
using UnityEngine;

namespace StageEvent
{
    public class StageEventController : MonoBehaviour
    {
        [SerializeField] private EventOption eventOptionPrefab;

        [SerializeField] private StageEventManager _stageEventManager;

        [SerializeField] private List<EventOption> _eventOptions;

        
        [ContextMenu("顯示隨機事件")]
        public void ShowEvent()
        {
            var randomEvent = _stageEventManager.GetRandomEvent(3);

            for (var index = 0; index < randomEvent.Count; index++)
            {
                var stageEvent = randomEvent[index];
                _eventOptions[index].UpdateUI(stageEvent);
            }
        }
    }
}