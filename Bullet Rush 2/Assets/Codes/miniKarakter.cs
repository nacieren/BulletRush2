using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class miniKarakter : MonoBehaviour
{
    public GameObject karakter;
    public GameObject �l�m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            �l�m.SetActive(true);
        }
        if (other.gameObject.name == "lvl2go")
        {
            karakter.GetComponent<Karakter>().stage2();
            Destroy(other);
        }
        if (other.gameObject.name == "lvl3go")
        {
            karakter.GetComponent<Karakter>().stage3();
            Destroy(other);
        }
        if (other.gameObject.name == "lvl4go")
        {
            karakter.GetComponent<Karakter>().stage4();
            Destroy(other);
        }
    }
    public void �ld�n()
    {
        SceneManager.LoadScene(0);
        Time.timeScale=1;
    }
}
