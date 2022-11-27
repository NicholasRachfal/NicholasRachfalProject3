using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class wearHelmet : MonoBehaviour
{

    public GameObject mask;
    public GameObject breathing;
  
    bool isTouching;

    void Start()
    {
        isTouching = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!isTouching)
        {
            mask.SetActive(true);
            gameObject.SetActive(false); 
            isTouching = true;
            breathing.SetActive(true);
        }
        else if (isTouching)
        {
            
            isTouching = false;
        }
    }
}
