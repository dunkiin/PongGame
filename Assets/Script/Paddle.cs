using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] 
    private string vertInputAxis = "VerticalP1";
    [SerializeField]
    Rigidbody rb;
    float vertInput;
    float speed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertInput = Input.GetAxis(vertInputAxis);
    }

    private void FixedUpdate()
    {
        Vector3 movement = Vector3.up * vertInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(transform.position + movement);
    }
}
