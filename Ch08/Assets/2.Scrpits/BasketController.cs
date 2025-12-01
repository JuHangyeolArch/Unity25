using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;

    private AudioSource aud;

    GameDirector gameDirector;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        this.aud = gameObject.GetComponent<AudioSource>();

        this.gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Àâ¾Ò´Ù.");
        if (other.gameObject.tag.Equals("apple"))
        {
            Debug.Log("»ç°ú");
            this.aud.clip = appleSE;
            this.gameDirector.GetApple();

        }
        else if (other.gameObject.tag.Equals("bomb"))
        {
            Debug.Log("ÆøÅº");
            this.aud.clip = bombSE;
            this.gameDirector.GetBomb();
        }

        this.aud.Play();

        Destroy(other.gameObject);
    }
}
