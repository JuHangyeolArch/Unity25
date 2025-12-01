using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;

    private float span = 1.0f;
    private float delta = 0f;

    private int ratio = 2;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            span = Random.Range(0.8f, 1.2f);
            GameObject go;
            int dice = Random.Range(0, 10);
            if (dice < ratio)
            {
                go = Instantiate(applePrefab);
            }
            else
            {
                go = Instantiate(bombPrefab);
            }
                delta = 0f;
            
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);

            go.transform.position = new Vector3(x, 5, z);
        }
    }
}
