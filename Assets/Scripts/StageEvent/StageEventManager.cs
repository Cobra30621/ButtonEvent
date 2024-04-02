using System.Collections.Generic;
using UnityEngine;

namespace StageEvent
{
    public class StageEventManager : MonoBehaviour
    {
        public StageEventData eventData;


        public List<StageEvent> GetRandomEvent(int count)
        {
            List<StageEvent> selectedItems = new List<StageEvent>();
            while (selectedItems.Count < 3) // Select 3 unique elements
            {
                int randomIndex = Random.Range(0, eventData.StageEvents.Count); // Generate a random index within the range of the list
                StageEvent selectedItem = eventData.StageEvents[randomIndex]; // Get the element at the random index

                if (!selectedItems.Contains(selectedItem)) // Check if the element is not already selected
                {
                    selectedItems.Add(selectedItem); // Add the element to the selected items list
                }
            }

            return selectedItems;
        }
    }
}