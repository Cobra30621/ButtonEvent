using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace StageEvent
{
    public class EventOption : MonoBehaviour
    {
        private StageEvent _stageEvent;

        [SerializeField] private TextMeshProUGUI eventName;
        [SerializeField] private Image image;
        
        public void UpdateUI(StageEvent stageEvent)
        {
            _stageEvent = stageEvent;
            eventName.text = stageEvent.EventName;
            image.sprite = stageEvent.image;
        }

        public void SelectedOption()
        {
            GameActionExecutor.ExecutorAction(_stageEvent.ActionParameter);
        }
    }
}