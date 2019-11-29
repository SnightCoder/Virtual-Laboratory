using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeflask : MonoBehaviour
{
    [Header("X: volume(ml) , Y: _FillAmount")]
    [Tooltip("X: volume(ml), Y: _FillAmount")]
    public Vector2[] Volume=new Vector2[]{};
    public float getVolumeLiquid(float volume, volumeflask volumeF){
        float minVo=volumeF.Volume[0].x;
        for(int i=0;i<volumeF.Volume.Length-1;i++){
            float w=0;
            float a1=volumeF.Volume[i].x;
            float a2=volumeF.Volume[i+1].x;
            float a1m=volumeF.Volume[i].y;
            float a2m=volumeF.Volume[i+1].y;
            if(volume>a1 && volume <= a2||volume==minVo){
                w=(100*(volume-a1)/(a2-a1))/100;
                return Mathf.Lerp(a1m,a2m,w);
            }
        }
        return 0;
    }
}
