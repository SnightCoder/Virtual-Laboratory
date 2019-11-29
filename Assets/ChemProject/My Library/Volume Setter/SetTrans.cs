using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(liquidsetvolume))]
public class SetTrans : MonoBehaviour
{
    float volume;
    Renderer ren;
     liquidsetvolume liqui;
     public Scrollbar scrollbar;
     public VolumeSetter volumesetter;
    // Start is called before the first frame update
    void Start()
    {
        liqui=GetComponent<liquidsetvolume>();
        ren=GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        volume=liqui.volume;
         if(volume==0){
            Color color= ren.material.GetColor("_TopColor");
            color.a=0;
            ren.material.SetColor("_TopColor",color);

            color= ren.material.GetColor("_Tint");
            color.a=0;
            ren.material.SetColor("_Tint",color);
        }
        else
        {
            Color color= ren.material.GetColor("_TopColor");
            color.a=255;
            ren.material.SetColor("_TopColor",color); 

            Color colors= ren.material.GetColor("_Tint");
            colors.a=0.4f;
            ren.material.SetColor("_Tint",colors);
        }

        if(volumesetter){
            if(scrollbar){
                volumesetter.volume=scrollbar.value*100*volumesetter.liquidSetVolume.volumeF.Volume[volumesetter.liquidSetVolume.volumeF.Volume.Length-1].x/100;
            }
        }
        
    }
}
