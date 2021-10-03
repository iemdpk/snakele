using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour
{
    // Start is called before the first frame update

     public GameObject hand;
     public float a;
     public int b; 
     public bool vertialUp ; 
     public bool vertialDown ; 

    public void openButton(){
        
        
        hand = GameObject.Find("Image");

        a = hand.transform.position.y;

        b =(int)a+5;


        hand.transform.position = new Vector3(360, (int)b, 0);
        Debug.Log(hand.transform.position.x);
    }


    public void closeButton(){
        
        
        hand = GameObject.Find("Image");

        a = hand.transform.position.y;

        b =(int)a-5;


        hand.transform.position = new Vector3(360, (int)b, 0);
        Debug.Log(hand.transform.position.x);
    }


    public void Start() {
            
            hand = GameObject.Find("Image");
            
            hand.transform.position = new Vector3(360,980, 0);
            Debug.Log(hand.transform.position.x);

            vertialUp = false;
            vertialDown = true;


    }    

    public void Update(){
        
        a = hand.transform.position.y;


    if(a<=980 && vertialUp == true){

        b =(int)a+8;
        hand.transform.position = new Vector3(360, (int)b, 0);
        Debug.Log(hand.transform.position.y);

        // Debug.Log("It is working on");
        }

        else if(vertialDown == true && 400<=a){
        
        b =(int)a-8;
        hand.transform.position = new Vector3(360, (int)b, 0);
        Debug.Log(hand.transform.position.y);

        }
        else if(a==396){
            vertialUp = true;
            vertialDown = false;
            Debug.Log("It is working");
        }
        else if(a==988){
            vertialUp = false;
            vertialDown = true;
            Debug.Log(hand.transform.position.y);
            Debug.Log("Value is Set");
        }
    }



}
