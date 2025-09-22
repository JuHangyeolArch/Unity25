using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;
    float startSpeed = 30f;
    float dRatio = 0.995f;
    float minSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            this.rotSpeed = this.startSpeed;
        }

        if (this.rotSpeed < this.minSpeed)
        {
            rotSpeed = 0f;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= this.dRatio;


    }
}
