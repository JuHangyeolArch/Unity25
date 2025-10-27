using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    public float jumpForce = 300f;
    public float walkForce = 30f;

    public float maxWalkSpeed = 2f;

    private int key = 0;
    private float speedX = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {

            this.rb.AddForce(transform.up * jumpForce);
        }


        key = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.key = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            this.key = 1;
        }

        this.speedX = Mathf.Abs(rb.velocity.x);
        if(speedX < maxWalkSpeed)
        {
            this.rb.AddForce(transform.right * this.walkForce * this.key);
        }


        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        
        }

    }
}
