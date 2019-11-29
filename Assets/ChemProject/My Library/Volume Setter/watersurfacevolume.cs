using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(volumeflask))]
public class watersurfacevolume : MonoBehaviour
{
     Renderer ren;
    [System.NonSerialized]
    public float volume=0;
    volumeflask volumeF;
    public volumeflask volumeScale;

   
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
         transform.localPosition=new Vector3(transform.localPosition.x,volumeF.getVolumeLiquid(volume,volumeF),transform.localPosition.z);
         if(volumeScale)
         transform.localScale=new Vector3(volumeF.getVolumeLiquid(volume,volumeScale),volumeF.getVolumeLiquid(volume,volumeScale),volumeF.getVolumeLiquid(volume,volumeScale));
    }
    
   
}
