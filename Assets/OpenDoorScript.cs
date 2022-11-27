using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    public GameObject wheel;
    public Animator open;
    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {
        Debug.Log(wheel.transform.rotation.z);
        if(wheel.transform.rotation.z > .47)
        {
            Debug.Log("Hit");
            open.enabled = true; 
        }
    }
}
