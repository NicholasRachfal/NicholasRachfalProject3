using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaximumReachedScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject water;
    public Animator anim;
    void Start()
    {
       water = GameObject.Find("WaterPlanes");
       anim = water.GetComponent<Animator>();
        playanim(); 
    }

    // Update is called once per frame
    void playanim()
    {
        anim.Play("Base Layer.waterRising");
    }
}
