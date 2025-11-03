using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
   //private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
     //   this.player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 playerPos = this.playerTransform.position;
        
        transform.position = new Vector3 (transform.position.x,playerPos.y + 4f,transform.position.z);
    }
}
