using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public GameObject ate�;
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
             ate�.GetComponent<Karakter>().ate�� = true;
             Debug.Log("girdin");
         }
     }
     private void OnTriggerExit(Collider other)
     {
        if(other.gameObject.tag=="Enemy") 
         { 
             ate�.GetComponent<Karakter>().ate�� = false;
             Debug.Log("��kt�n");
         }
     }
     */
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            ate�.GetComponent<Karakter>().ate�� = true;
            Debug.Log("girdin");
        }
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Enemy")
        {
            ate�.GetComponent<Karakter>().ate�� = false;
            Debug.Log("��kt�n");
        }
    }
}
