using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPriceOnCollision : MonoBehaviour
{
    public GameObject boat; 
    public TextMeshPro price;
  
    private void OnTriggerEnter(Collider other)
    {
        price.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        price.gameObject.SetActive(false);
    }
}
