using System.Collections;
using System.IO;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    public GameObject Brush;
    public float BrushSize = 0.1f;
    public RenderTexture RTexture;

    public Vector3 rotate=Vector3.zero, pointplus=Vector3.up * 0.1f;

    public bool removeAll = false;

    public LayerMask layer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Delete))removeAll=true;
        if (Input.GetMouseButton(0))
        {
            //cast a ray to the plane
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit,Mathf.Infinity,layer))
            {
                if (hit.collider.CompareTag(StaticString.Board)){
                //instanciate a brush
                var go = Instantiate(Brush, hit.point +pointplus , Quaternion.Euler(rotate), transform);
                go.transform.localScale = Vector3.one * BrushSize;
                }
            }

        }
        if (Input.GetMouseButton(1))
        {
            //cast a ray to the plane
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                //remove a brush
                if (hit.collider.CompareTag(StaticString.Brush))
                    Destroy(hit.transform.gameObject);
            }

        }

        if (removeAll)
        {
            removeAll = false;
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            } 
        }
    }

    public void Save()
    {
        StartCoroutine(CoSave());
    }

    private IEnumerator CoSave()
    {
        //wait for rendering
        yield return new WaitForEndOfFrame();
        Debug.Log(Application.dataPath + "/savedImage.png");

        //set active texture
        RenderTexture.active = RTexture;

        //convert rendering texture to texture2D
        var texture2D = new Texture2D(RTexture.width, RTexture.height);
        texture2D.ReadPixels(new Rect(0, 0, RTexture.width, RTexture.height), 0, 0);
        texture2D.Apply();

        //write data to file
        var data = texture2D.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/savedImage.png", data);


    }
}