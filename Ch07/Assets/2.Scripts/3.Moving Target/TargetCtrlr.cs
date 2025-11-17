using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCtrlr : MonoBehaviour
{
    GenerateTarget gt;

    // Start is called before the first frame update
    void Start()
    {
        this.gt = GameObject.FindAnyObjectByType<GenerateTarget>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bamsongi"))
        {
            this.gt.Generate();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
