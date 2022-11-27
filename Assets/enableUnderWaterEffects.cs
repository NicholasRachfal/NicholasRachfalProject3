using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class enableUnderWaterEffects : MonoBehaviour
{
    public GameObject waterPlanes;
    public FogEffect fog;
    public UnderWaterEffect underWater;
    public AudioSource waterAudio;
    public GameObject waterPipes;
    public GameObject bubbles;
    public GameObject mask;
    public GameObject breathing;
    public GameObject thePlayer;
    public GameObject destination1;

    public InputActionReference toggleReference = null;
    public InputActionReference telport1 = null; 

    // Start is called before the first frame update
    void Start()
    {
        waterAudio = gameObject.GetComponent<AudioSource>();
        fog = gameObject.GetComponent<FogEffect>();
        underWater = gameObject.GetComponent<UnderWaterEffect>();
        

    }

    private void Awake()
    {
        toggleReference.action.started += Toggle;
        telport1.action.started += Location1;
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
        telport1.action.started -= Location1;
    }

    private void Location1(InputAction.CallbackContext context)
    {
        thePlayer.transform.localPosition = destination1.transform.localPosition;

    }
    private void Toggle(InputAction.CallbackContext context)
    {
        bool isActiveMask = !mask.activeSelf;
        bool isActiveBreathing = !breathing.activeSelf;
        mask.SetActive(isActiveMask);
        breathing.SetActive(isActiveBreathing);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 waterPos = GameObject.Find("WaterPlanes").transform.position;

        if(waterPos.y > 0)
        {
            fog.enabled = true;
            underWater.enabled = true;
            waterAudio.enabled = true;
            bubbles.SetActive(true);
            

        }

        if(waterPos.y > 1)
        {
            waterPipes.SetActive(false);
        }


        
    }
}
