using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2_Element : MonoBehaviour
{
    public float volume=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(volume<=0)Destroy(gameObject);
    }
    public void SendDamage(float dam,float delay){
        volume-=dam*Time.deltaTime*delay;
    }
}
