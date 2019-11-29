using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockAnimator : MonoBehaviour
{
    private const float
        hoursToDegrees = -360 / 12f,
        minsToDegrees = -360 / 60f,
        secsToDegrees = -360 / 60f;

    public Transform hours, mins, secs;
    public bool analog;

    // Update is called once per frame
    void Update()
    {
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            hours.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
            mins.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minsToDegrees);
            secs.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secsToDegrees);
        }
        else
        {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
            mins.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minsToDegrees);
            secs.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secsToDegrees);
        }
    }
}
