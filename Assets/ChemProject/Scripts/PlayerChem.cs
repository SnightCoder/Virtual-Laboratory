using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


[RequireComponent(typeof(SmoothLookAtCrossHair))]
public class PlayerChem : MonoBehaviour
{
    SmoothLookAtCrossHair smooth;
    public float distance = Mathf.Infinity;
    RigidbodyFirstPersonController playerController;
    float originHeight;
    public bool crouch = false;
    public int indexchoice = 0;
    public GameObject targetPlane;

    public Transform leftHandPo, rightHandPo;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<RigidbodyFirstPersonController>();
        smooth = GetComponent<SmoothLookAtCrossHair>();
        originHeight = playerController.GetComponent<CapsuleCollider>().height;
        anim = GetComponent<Animator>();
    }
    public bool turnoff=true;
    void SetBoolAnim(bool b)
    {
        if(turnoff)
        anim.SetBool("RightGrabbed", b);
        anim.SetBool("LeftGrabbed", !b);
    }
    // Update is called once per frame
    void Update()
    {
        #region check index items
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            indexchoice = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            indexchoice = 1;
        }
        if(indexchoice==0){
            SetBoolAnim(true);
        }
        else if(indexchoice==1){
            SetBoolAnim(false);
        }
        #endregion

        Camera.main.usePhysicalProperties=Input.GetKey(KeyCode.F);
        if(!Input.GetKey(KeyCode.F))
        Camera.main.fieldOfView=60f;

        crouch = Input.GetKey(KeyCode.LeftControl);
        if (crouch)
            playerController.GetComponent<CapsuleCollider>().height = originHeight / 3.5f;
        else
            playerController.GetComponent<CapsuleCollider>().height = originHeight;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!GetComponent<InventoryList>().isFull())
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out var hit, distance))
                {
                    //if
                    if (hit.collider.CompareTag(StaticString.ErlenmeyerFlask))
                    {
                        anim.SetBool("RightGrabbed", false);
                        anim.SetBool("LeftGrabbed", false);
                        turnoff=false;

                        smooth.target = hit.transform.position + Vector3.up * .01f;
                        smooth.enabled = true;
                        smooth.flask = hit.collider.gameObject;
                    }

                    if (hit.collider.CompareTag(StaticString.beaker))
                    {
                        anim.SetBool("RightGrabbed", false);
                        anim.SetBool("LeftGrabbed", false);
                        turnoff=false;

                        smooth.target = hit.transform.position + Vector3.up * .01f;
                        smooth.enabled = true;
                        smooth.flask = hit.collider.gameObject;
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R) || Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit, distance))
            {
                if (hit.collider.CompareTag(StaticString.Table))
                    GetComponent<InventoryList>().useItem(indexchoice, hit.point);
            }
        }
        if (targetPlane)
        {
            if (GetComponent<InventoryList>().Items[indexchoice])
            {
                targetPlane.SetActive(true);
                Ray rays = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(rays, out var hits, distance))
                {
                    if (!hits.collider.CompareTag("Player"))
                        targetPlane.transform.position = hits.point + Vector3.up * .01f;
                    else targetPlane.SetActive(false);
                }
            }
            else targetPlane.SetActive(false);
        }
    }
}
