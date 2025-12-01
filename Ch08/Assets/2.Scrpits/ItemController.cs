using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float dropspeed = -3f;


    void Update()
    {
        transform.Translate(0f, this.dropspeed * Time.deltaTime, 0f);

        if (transform.position.y < -1.0f) 
        {
            Destroy(gameObject);
        }
    }
}
