using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class ScheduleForToday : MonoBehaviour
{

    public string D;

    // Start is called before the first frame update
    void Start()
    {


        /// Entire schedule for the week controlled by the empty string 'D'
        if (D == "Monday" || D == "monday")
        {
            Debug.Log("Schedule for " + D + ": Hop into my rocket ship and fly to Mars");
        }
        else if (D == "Tuesday" || D == "tuesday")
        {
            Debug.Log("Schedule for " + D + ": Get lost in the wilderness");
        }
        else if (D == "Wednesday" || D == "wednesday")
        {
            Debug.Log("Schedule for " + D + ": Drink enough Cocio to have a mental breakdown");
        }
        else if (D == "Thursday" || D == "thursday")
        {
            Debug.Log("Schedule for " + D + ": Sleep the entire day");
        }
        else if (D == "Friday" || D == "friday")
        {
            Debug.Log("Schedule for " + D + ": Fight an alligator");
        }
        else if (D == "Saturday" || D == "saturday")
        {
            Debug.Log("Schedule for " + D + ": Recover from a hangover");
        }
        else if (D == "Sunday" || D == "sunday")
        {
            Debug.Log("Schedule for " + D + ": Eat the sun");
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
