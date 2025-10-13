using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    private float span = 1.0f;
    private float delta = 0f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0f;
            GameObject go = Instantiate(arrowPrefab);
            float px = Random.Range(-8.0f, 8.0f);
            go.transform.position = new Vector3(px, 7f, 0f);
        }
    }
}
