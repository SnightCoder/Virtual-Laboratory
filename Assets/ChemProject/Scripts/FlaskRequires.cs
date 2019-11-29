using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Outline))]
[RequireComponent(typeof(FlaskShowE))]
public class FlaskRequires : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Outline>().OutlineWidth = 0;
        GetComponent<FlaskShowE>().pressE = transform.Find(StaticString.PressE).gameObject;
    }
}
