using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fe_Element : MonoBehaviour
{
    public static float AtomicNumber=26;
    public static string ElementTag = StaticString.Fe;
    public static float AtomicMass = 56;
    public static float AtomicMassCorrect = 55.845f;

    public bool burning=false;

    private void OnCollisionEnter(Collision other) {
        
    }

    private void OnTriggerEnter(Collider other) {
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag(StaticString.O2)){
            if(burning)
            BurnInO2(other);
        }
    }

    void BurnInO2(Collider other){
        other.GetComponent<O2_Element>().SendDamage(2,1);
    }
}
