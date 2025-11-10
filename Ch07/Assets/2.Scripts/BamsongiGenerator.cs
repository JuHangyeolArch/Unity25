using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject go = Instantiate(bamsongiPrefab);
            go.transform.position = new Vector3(transform.position.x, transform.position.y - 5, transform.position.z + 1);
            go.GetComponent<BamsongiCtrlr>().Shoot(new Vector3(0, 800, 2000));

        }
    }
}
