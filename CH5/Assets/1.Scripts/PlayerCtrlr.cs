using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlr : MonoBehaviour
{
    public float movestep = 10f;
    private float movespeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void Turn_Left() 
    {
        this.movespeed = -this.movestep;
    }

    public void Turn_Right()
    {
        this.movespeed = this.movestep;
    }

    void PlayerMove() 
    {

        transform.Translate(movespeed, 0f, 0f);

        this.movespeed = this.movespeed * 0.90f;

        if (movespeed < 0.01f && movespeed > -0.01f)
        {
            movespeed = 0f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.Turn_Left();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.Turn_Right();
        }

        this.PlayerMove();

    }
}
