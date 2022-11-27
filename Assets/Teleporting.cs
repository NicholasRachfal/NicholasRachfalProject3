using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia.Locomotors.Teleporter; 

public class Teleporting : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;


    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position; 
    }

}
