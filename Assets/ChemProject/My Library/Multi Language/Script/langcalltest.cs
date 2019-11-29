using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class langcalltest : MonoBehaviour
{
    public Text text;
    float i = 0, j = 0;

    // Update is called once per frame
    void Update()
    {
        if (i == 0)
            text.text = lange.hello();
        else
        {
            text.text = lange.hi();
        }
    }
    public void ChangeText()
    {
        if (i == 0) i = 1;
        else
            i = 0;
    }
    public void Changlang()
    {
        if (j == 0)
        {
            lange.lang = lange.vietnam_language;
            j = 1;
        }
        else
        {
            lange.lang = lange.english_language;
            j = 0;
        }
    }

}
