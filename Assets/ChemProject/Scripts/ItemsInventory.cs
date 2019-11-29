using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsInventory : MonoBehaviour
{
    public PlayerChem chem;
    public InventoryList inventory;
    public int index;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    bool checkeds = false;

    // Update is called once per frame
    void Update()
    {
        if (index == 0)
        {
            if (inventory.Items[0])
            {
                text.text = lange.RightArm() + inventory.Items[0].name;
                CheckIndex(index, chem.indexchoice, lange.RightArm() + inventory.Items[0].name);
            }
            else
            {
                text.text = lange.RightArm();
                CheckIndex(index, chem.indexchoice, lange.RightArm());
            }
        }
        else if (index == 1)
        {
            if (inventory.Items[1])
            {
                text.text = lange.leftArm() + inventory.Items[1].name;
                CheckIndex(index, chem.indexchoice, lange.leftArm() + inventory.Items[1].name);
            }
            else
            {
                text.text =lange.leftArm();
                CheckIndex(index, chem.indexchoice, lange.leftArm());
            }

        }
    }
    void CheckIndex(int i, int j, string s)
    {
        if (j == 0 && i == 0)
        {
            text.text = s + "(X)";
        }
        if (j == 1 && i == 1)
        {
            text.text = s + "(X)";
        }
    }
}