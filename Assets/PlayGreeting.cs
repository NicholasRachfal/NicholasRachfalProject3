using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGreeting : MonoBehaviour
{
    public AudioSource greet;
    // Start is called before the first frame update
    private void Start()
    {
        greet = gameObject.GetComponent<AudioSource>(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        greet.Play(); 
    }
}
