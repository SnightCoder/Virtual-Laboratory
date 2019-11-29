using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent(typeof(InventoryList))]
public class SmoothLookAtCrossHair : MonoBehaviour
{
    public Vector3 target;
    public float degreesPerSecond;
    public RigidbodyFirstPersonController rib;
    public HeadBob head;
    Vector3 origin;
    public GameObject cameras;
    public Animator anim;
    
    [HideInInspector]
    public GameObject flask;

    InventoryList list;


    private void Awake() {
        enabled=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        head.enabled = false;
        list=GetComponent<InventoryList>();
        origin =cameras.transform.eulerAngles;
        i=true;
    }
    void OnEnable()
    {
        rib.enabled = false;
        head.enabled = false;
        origin =cameras.transform.eulerAngles;
        i=true;
    }
    bool i = true;
    // Update is called once per frame
    void Update()
    {
        if (RotatePo(i))
        {
            //     enabled=false;
            //    rib.enabled=true;
            //  head.enabled=true;
            if (!i)
            {
                if (cameras.transform.rotation == Quaternion.Lerp(cameras.transform.rotation, Quaternion.Euler(origin), .2f))
                {
                    enabled = false;
                    rib.enabled = true;
                    i = true;
                    head.enabled = true;
                };
                cameras.transform.rotation = Quaternion.Lerp(cameras.transform.rotation, Quaternion.Euler(origin), .2f);
                return;
            }
            setAnimation(i);
        }
    }
    bool RotatePo(bool i)
    {
        if (i)
        {
            Vector3 dirFormMeToTarget = target - cameras.transform.position;
            //dirFormMeToTarget.y=0.0f;
            Quaternion lookRotation = Quaternion.LookRotation(dirFormMeToTarget);
            cameras.transform.rotation = Quaternion.Lerp(cameras.transform.rotation, lookRotation, Time.deltaTime * (degreesPerSecond / 360.0f));
            if (cameras.transform.rotation == Quaternion.Lerp(cameras.transform.rotation, lookRotation, Time.deltaTime * (degreesPerSecond / 360.0f)))
            {
                return true;
            }
            return false;
        }
        return true;
    }
     void setDefaultPos(){
            i = false;
            setAnimation(i);
            GetComponent<PlayerChem>().turnoff=true;
            //set flask position
            list.addItem(flask);  
    }
        //if
    void setAnimation(bool a){
            anim.SetBool(StaticString.RightGrabErlenmeyerFlask,a);
            // GetComponent<Rigidbody>().isKinematic=a;
    }
}
