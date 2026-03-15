using UnityEngine;
using System;
public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot;
    [SerializeField]
    Transform minutesPivot;
    [SerializeField] Transform secondsPivot;

// Update is called once per frame
    void Update()
    {
        Debug.Log(DateTime.Now.TimeOfDay.TotalHours);
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, -30f * (float)DateTime.Now.TimeOfDay.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)DateTime.Now.TimeOfDay.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)DateTime.Now.TimeOfDay.TotalSeconds);
    
    }
}
