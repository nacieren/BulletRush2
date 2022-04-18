using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basla : MonoBehaviour {
    public GameObject karakter;
    public Transform start;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(karakter, start.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
