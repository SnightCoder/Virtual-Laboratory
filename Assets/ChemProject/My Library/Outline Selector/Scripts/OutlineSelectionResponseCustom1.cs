using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SelectionManager))]
public class OutlineSelectionResponseCustom1 : MonoBehaviour, ISelectionResponse
{
    public float OutlineWidth = 10;
    public Image crossHair;
    public void OnDeselect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = 0;
        }
        SetActive(false,selection);
    }

    public void OnSelect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if (outline != null)
        {
            outline.OutlineWidth = OutlineWidth;
        }
        SetActive(true,selection);
    }

    void SetActive(bool active, Transform g)
    {
        g.GetComponent<FlaskShowE>().Show = active;
        if(crossHair)
        crossHair.enabled = active;
    }

}
