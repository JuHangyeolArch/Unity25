using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;
using UnityEditor.Animations;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float jumpForce = 400f;
    public float walkForce = 30f;

    public float maxWalkSpeed = 2f;

    private int key = 0;
    private float speedX = 0f;
    private float speedY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rb = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && 
            this.rb.velocity.y==0) 
        {

            this.rb.AddForce(transform.up * jumpForce);
            this.animator.SetTrigger("Jump Trigger");
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

        this.speedX = Mathf.Abs(this.rb.velocity.x);
        this.speedY = Mathf.Abs(this.rb.velocity.y);
        if (speedX < maxWalkSpeed)
        {
            this.rb.AddForce(transform.right * this.walkForce * this.key);
        }


        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        
        }

        if (this.rb.velocity.y == 0)
        {
            this.animator.speed = this.speedX / 2;
        }
        else {
            this.animator.speed = this.speedY / 2;
        }

        if (transform.position.y < -10f) 
        {
            string sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneName);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Goal!");
        SceneManager.LoadScene("Clear Scene");
    }

}
