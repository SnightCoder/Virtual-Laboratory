using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class btnchangetext : MonoBehaviour
{
     Text t;
    // Start is called before the first frame update
    void Start()
    {
        t=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        t.text=lange.changelanguage();
    }
}
