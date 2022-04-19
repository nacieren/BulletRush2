using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public GameObject ateþ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Enemy")
         {
             ateþ.GetComponent<Karakter>().ateþþ = true;
             Debug.Log("girdin");
         }
     }
     private void OnTriggerExit(Collider other)
     {
        if(other.gameObject.tag=="Enemy") 
         { 
             ateþ.GetComponent<Karakter>().ateþþ = false;
             Debug.Log("çýktýn");
         }
     }
     */
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            ateþ.GetComponent<Karakter>().ateþþ = true;
            Debug.Log("girdin");
        }
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Enemy")
        {
            ateþ.GetComponent<Karakter>().ateþþ = false;
            Debug.Log("çýktýn");
        }
    }
}
