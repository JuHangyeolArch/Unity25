using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class ArrowCtrlr : MonoBehaviour
{
    float dropspeed = 0.0001f;
    public float arrow_rardius = 0.6f;
    public float player_radius = 0.7f;

    Transform playerTransform;

    // Start is called before the first frame update

    // Update is called once per frame


    void Update()
    {
        this.playerTransform = GameObject.Find("player").GetComponent<Transform>();
        this.dropspeed *= 1.4f;
        this.transform.Translate(0, -dropspeed, 0);
        CheckCollison();

        if (transform.position.y < -7f) 
        {
            Destroy(gameObject);
        }
    }

    private void CheckCollison()
    {
        Vector2 arrowPosition = transform.position;
        Vector2 playerPosition = playerTransform.position;
        float distance = (arrowPosition - playerPosition).magnitude;

        if (distance < this.arrow_rardius + this.player_radius)
        {
            Destroy(gameObject);
            
        }
    }
}
