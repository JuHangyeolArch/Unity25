using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hpGage;

    public void DecreaseHP()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void Go_Left()
    { 

    }

}
