using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frndScript : MonoBehaviour
{

    public float speed = 0.0010f;
    public GameObject ballFrnd;
    
    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {   

        ballFrnd = GameObject.Find("SphereFrnd");
        // cylender = GameObject.Find("Cylinder");
        Debug.Log("It is Srarted First");
        ballFrnd.transform.SetParent(parent);
    }

    // Update is called once per frame
    void Update()
    {   

        ballFrnd = GameObject.Find("SphereFrnd");
        Debug.Log("It is Srarted First");

        if(Input.GetKey("p")){
        transform.Translate(new Vector3(0,speed,0));

        }

        


        // Debug.Log("Deepak Mishra");
    }

    void OnTriggerEnter2D(Collider2D other)
    {   

        GameObject cloneFrnds = Instantiate(ballFrnd,new Vector3(0f,-3f,0f),ballFrnd.transform.rotation);
        cloneFrnds.name = "SphereFrnd";
        cloneFrnds.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
    

        Debug.Log("It is Deleted Now");
    }
}
