using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCtrlr : MonoBehaviour
{
    public float dropspeed = 0.3f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropspeed, 0);

        if (transform.position.y < -7f) 
        {
            Destroy(gameObject);
        }
    }
}
