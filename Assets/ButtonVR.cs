using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events; 
using UnityEngine;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public GameObject objectToSpawn; 
    GameObject presser;
    AudioSource sound;
    bool isPressed; 

    // Start is called before the first frame update
    void Start()
    {
        //objectToSpawn = GetComponent<GameObject>(); 
        sound = GetComponent<AudioSource>();
        isPressed = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            button.transform.localPosition = new Vector3(-1.14f, 0.547f, -0.561f);
            presser = other.gameObject;
            onPress.Invoke();
            Spawn(); 
            sound.Play();
            isPressed = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(-1.14f, 0.665f, -0.561f);
            onRelease.Invoke();
            isPressed = false; 
        }
    }
    public void Spawn()
    {
        GameObject newObject = Instantiate(objectToSpawn, new Vector3(transform.position.x-.6f, transform.position.y, transform.position.z), transform.rotation);
        //item.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        //objectToSpawn.transform.localPosition = new Vector3(-0.067f, -0.647f, 3.212f);
        //item.AddComponent<Rigidbody>(); 
    }
}
