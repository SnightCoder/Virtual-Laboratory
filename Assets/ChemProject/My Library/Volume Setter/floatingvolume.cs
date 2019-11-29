using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(volumeflask))]
public class floatingvolume : MonoBehaviour
{
    BoxCollider ren;
    [System.NonSerialized]
    public float volume = 0;
    public float floattingMinus = 0;
    volumeflask volumeF;
    Vector3 oldEulerAngles;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<BoxCollider>();
        volumeF = GetComponent<volumeflask>();
        oldEulerAngles = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        volume = Mathf.Clamp(volume, volumeF.Volume[0].x, volumeF.Volume[volumeF.Volume.Length - 1].x);
        ren.center = new Vector3(ren.center.x,volumeF.getVolumeLiquid(volume,volumeF) - floattingMinus, ren.center.z);
        ren.enabled = (oldEulerAngles == transform.rotation.eulerAngles);
    }
}
