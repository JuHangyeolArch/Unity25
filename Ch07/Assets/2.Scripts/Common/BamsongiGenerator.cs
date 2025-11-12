using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 5f;
    private float startValue;
    private float power;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            this.startValue = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            this.power = Input.mousePosition.y - this.startValue;

            GameObject go = Instantiate(bamsongiPrefab);
            go.transform.position = new Vector3(transform.position.x, transform.position.y - 5, transform.position.z + 1);
            go.GetComponent<BamsongiCtrlr>().Shoot((transform.forward + transform.up * 0.5f) * throwForce * power);

        }
    }
}
