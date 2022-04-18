using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class HareketEt : MonoBehaviour
{
    public Joystick joystick;
    public float hýz = 0.5f;
    public float mesafe;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();

    }

    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * -hýz,rigidbody.velocity.y,joystick.Vertical*-hýz);

    }
}