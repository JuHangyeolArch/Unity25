using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTF : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 80f;


    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * this.rotateSpeed * Time.deltaTime;
        float zSpeed = zInput * this.moveSpeed * Time.deltaTime;

        transform.Translate(0, 0, zSpeed);
        transform.Rotate(0, xSpeed, 0);
    }
}
