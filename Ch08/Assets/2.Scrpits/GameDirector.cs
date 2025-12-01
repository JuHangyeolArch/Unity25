using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    public GameObject pointText;
    private TextMeshProUGUI pointTextmesh;
    private int point;

    // Start is called before the first frame update
    void Start()
    {
        this.point = 0;
        this.pointTextmesh = this.pointText.GetComponent<TextMeshProUGUI>();
        this.pointTextmesh.text = "Point: 0";
    }

    // Update is called once per frame
    void Update()
    {
        this.pointTextmesh.text = "Point:" + this.point;
    }

    public void GetApple() 
    {
        this.point += 10;    
    }
    public void GetBomb()
    {
        this.point /= 2;
    }
}
