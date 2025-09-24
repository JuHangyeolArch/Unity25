using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float decreaseRatio = 0.98f;
    public float speedRatio = 1000f;

    float speed = 0f;
    float swipeLength;

    Vector2 startPos;
    Vector2 endPos;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //this.speed = 0.2f;
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) 
        {
            this.endPos = Input.mousePosition;
            this.swipeLength = endPos.x - startPos.x;
            this.speed = this.swipeLength / speedRatio;
        }

        transform.Translate(this.speed, 0f, 0f);
        this.speed *= decreaseRatio;
    }
}
