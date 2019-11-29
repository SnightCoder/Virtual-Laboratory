using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSetter : MonoBehaviour
{
    public float volume = 0, volumeEnableSurface = 0;
    public liquidsetvolume liquidSetVolume;
    public floatingvolume floatingVolume;
    public watersurfacevolume waterSurfaceVolume;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        volume = Mathf.Clamp(volume, liquidSetVolume.volumeF.Volume[0].x, liquidSetVolume.volumeF.Volume[liquidSetVolume.volumeF.Volume.Length - 1].x);
        if (liquidSetVolume) liquidSetVolume.volume = volume;
        if (floatingVolume) floatingVolume.volume = volume;
        if (waterSurfaceVolume)
        {
            waterSurfaceVolume.volume = volume;
            waterSurfaceVolume.gameObject.SetActive(waterSurfaceVolume.volume > volumeEnableSurface);
        }
    }
}
