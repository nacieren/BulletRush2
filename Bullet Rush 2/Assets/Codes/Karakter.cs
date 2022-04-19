using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public Transform silahUcu1;
    public Transform silahUcu2;
    public Transform Enemy;
    public Transform mermi;
    public Transform karakter;
    public float fireSpeed;
    public float mesafe;
    public int sayaç;
    public float ateþEt = 0.5f;
    public bool canFire = true;
    public bool ateþþ=false;
    public GameObject Lvl1;
    public GameObject Lvl2;
    public GameObject Lvl3;
    public GameObject Lvl4;
    public GameObject fireObje;
    public int killer;
    


    // Start is called before the first frame update
    void Start()
    {
        stage1();
    }

    // Update is called once per frame
    void Update()
    {
        killer=fireObje.GetComponent<Fire>().kill;
        //mesafe = Vector3.Distance(transform.position, Enemy.position);
        if(ateþþ==true)
        {
            if (canFire == true)
            {
                ShotFire();
            }

        }
        sayaç= fireObje.GetComponent<Fire>().kill ;
     

    }
    public void ShotFire()
    {
        Transform tempFireBall1;
        Transform tempFireBall2;
        tempFireBall1 = Instantiate(mermi, silahUcu1.position, Quaternion.identity);
        tempFireBall2 = Instantiate(mermi, silahUcu2.position, Quaternion.identity);
        tempFireBall1.GetComponent<Rigidbody>().AddForce(silahUcu1.up * fireSpeed);
        tempFireBall2.GetComponent<Rigidbody>().AddForce(silahUcu1.up * fireSpeed);
        canFire = false;
        StartCoroutine(waitFire());

    }
    public IEnumerator waitFire()
    {
        yield return new WaitForSeconds(0.1f);
        canFire = true;

    }
   

    public void stage1() 
    {
        Lvl1.SetActive(true);
       /* for (int i = 0; i < 2; i++)
        {
            i = 0;
            if (sayaç<= killer)
            {
                ateþþ = false;
                break;
            }
        }
       */
    }
    public void stage2()
    {
        ateþþ = false;
        karakter.transform.position = new Vector3(0, 0.159f, 2.4733f);
        Lvl1.SetActive(false);
        Lvl2.SetActive(true);    

    }
    public void stage3() {
        ateþþ = false;
        karakter.transform.position = new Vector3(0, 0.159f, 2.4733f);
        Lvl2.SetActive(false);
        Lvl3.SetActive(true);
      
    }
    public void stage4()
    {
        ateþþ = false;
        karakter.transform.position = new Vector3(0, 0.159f, 2.4733f);
        Lvl3.SetActive(false);
        Lvl4.SetActive(true);     
    }


}