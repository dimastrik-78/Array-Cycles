using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private float Speed;
    private Renderer mat1;
    private Renderer mat2;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mat1 = GetComponent<Renderer>();
        mat2 = GetComponent<Renderer>();
    }

    void Update()
    {
        Speed = rb.velocity.magnitude;
        if (Speed > 6)
        {
            mat1.material.color = Color.yellow;
        }
        else
        {
            mat2.material.color = Color.cyan;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(transform.up * 65, ForceMode.Impulse);
    }
}
