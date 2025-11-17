using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRB : MonoBehaviour
{

    public float moveSpeed = 20f;
    public float rotateSpeed = 40f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float rotSpeed = xInput * rotateSpeed * Time.deltaTime;

        rb.rotation = rb.rotation * Quaternion.Euler(0, rotSpeed, 0);

        Vector3 move = zInput * transform.forward * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + move);
    }
}
