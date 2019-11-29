using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(volumeflask))]
public class liquidsetvolume : MonoBehaviour
{
    Renderer ren;
     [System.NonSerialized]
    public float volume=0;
     [System.NonSerialized]

    public volumeflask volumeF;

   
    // Start is called before the first frame update
    void Start()
    {
        ren=GetComponent<Renderer>();
        volumeF=GetComponent<volumeflask>();
    }

    // Update is called once per frame
    void Update()
    {
        volume=Mathf.Clamp(volume,volumeF.Volume[0].x,volumeF.Volume[volumeF.Volume.Length-1].x);
        ren.material.SetFloat("_FillAmount",volumeF.getVolumeLiquid(volume,volumeF));
    }
}
