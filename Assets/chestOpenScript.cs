using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro; 

public class chestOpenScript : MonoBehaviour
{
    public GameObject egg;
    public GameObject eggText; 
    public Animator anim;
    public Animator animEgg;
    public AudioSource soundOpen;
    public AudioSource soundClosed;
    GameObject presser;
    bool isOpen;

    Animator m_Animator;
    string m_ClipName;
    AnimatorClipInfo[] m_CurrentClipInfo;

    float m_CurrentClipLength;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>(); 
        anim = gameObject.GetComponent<Animator>();
        isOpen = false;

        m_CurrentClipInfo = this.m_Animator.GetCurrentAnimatorClipInfo(0);
        //Access the current length of the clip
        m_CurrentClipLength = m_CurrentClipInfo[0].clip.length;
        //Access the Animation clip name
        m_ClipName = m_CurrentClipInfo[0].clip.name;
    }

    void OnGUI()
    {
        //Output the current Animation name and length to the screen
        //GUI.Label(new Rect(0, 0, 200, 20), "Clip Name : " + m_ClipName);
        //GUI.Label(new Rect(0, 30, 200, 20), "Clip Length : " + m_CurrentClipLength);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isOpen)
        {
            anim.Play("OpenChest");
            animEgg.SetTrigger("eggTrigger");
            soundOpen.Play();
            eggText.SetActive(true); 
            isOpen = true; 
        }
        else if(isOpen)
        {
            anim.Play("CloseChest");
            soundClosed.Play(); 
            isOpen = false; 
        }
    }
}
