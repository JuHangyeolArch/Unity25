using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiCtrlr : MonoBehaviour
{
    public int forwardForce = 2000;
    public int upForce = 200;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.Shoot(new Vector3(0, this.upForce, this.forwardForce));
    }

    public void Shoot(Vector3 dir)
    { 
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        GetComponentInChildren<MeshRenderer>().enabled = false;
        Destroy(gameObject, 1);
    }

}
