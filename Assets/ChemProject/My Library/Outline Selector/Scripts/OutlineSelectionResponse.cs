using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(SelectionManager))]
public class OutlineSelectionResponse : MonoBehaviour, ISelectionResponse
{
    public float OutlineWidth=10;
    public void OnDeselect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if (outline != null){
            outline.OutlineWidth = 0;
        }
    }

    public void OnSelect(Transform selection)
    {
        var outline = selection.GetComponent<Outline>();
        if (outline != null){
            outline.OutlineWidth = OutlineWidth;
         }
    }

}
