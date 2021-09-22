using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetObjectPosition : MonoBehaviour
{
    Vector3 originalPos;
    public GameObject ball;
    public Rigidbody rb;

    void Start()
    {
        originalPos = ball.transform.position;
        rb = ball.GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        print("presionado");
        ball.transform.position = originalPos;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
