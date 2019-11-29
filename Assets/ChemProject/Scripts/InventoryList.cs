using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryList : MonoBehaviour
{
    public GameObject[] Items;

    public bool addItem(GameObject game)
    {
        int i = 0;
        foreach (var item in Items)
        {
            if (!item)
            {
                //pickUpPo
                Items[i] = game;
                Items[i].transform.parent=gameObject.transform;
                if (i == 0)
                    Items[i].transform.localPosition = GetComponent<PlayerChem>().rightHandPo.localPosition;
                else if (i > 0)
                    Items[i].transform.localPosition = GetComponent<PlayerChem>().leftHandPo.localPosition;
                break;
            }
            i++;
        }
        if (i == Items.Length) return false;
        else return true;
    }

    public bool isFull()
    {
        int i = 0;
        foreach (var item in Items)
        {
            if (!item)
                break;
            i++;
        }
        if (i == Items.Length) return true;
        else return false;
    }
    public bool isNull()
    {
        int i = 0;
        foreach (var item in Items)
        {
            if (!item)
                break;
            i++;
        }
        if (i == 0) return true;
        else return false;
    }

    public void useItem(int index, Vector3 point)
    {

        if (Items[index])
        {
            //if
            Items[index].transform.parent=null;
            if (Items[index].CompareTag(StaticString.ErlenmeyerFlask))
            {
                Items[index].transform.position = point + Vector3.up * .095f;
            }
            if (Items[index].CompareTag(StaticString.beaker))
            {
                Items[index].transform.position = point + Vector3.up * .075f;
            }
            Items[index] = null;
        }
    }
}
