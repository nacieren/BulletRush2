using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform Karakter;
    public float mesafe;
    private float hareketEt=1.2f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        mesafe = Vector3.Distance(transform.position, Karakter.position);
        if (mesafe <= hareketEt)
        {
            agent.destination = Karakter.position;
        }
    }
}
