using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class checkout : MonoBehaviour
{
    public GameObject egg;
    public GameObject eggText;
    public GameObject binText; 
    GameObject presser;
    bool isTouching;

    

    void Start()
    {
        //binText = GetComponent<TextMeshPro>(); 
        isTouching = false;
    }

    string updateText(string text)
    {
        string getPrice = ""; 
        for(int i = 0; i < text.Length; i++)
        {
            if(text[i] == '$')
            {
                getPrice = text[i + 1].ToString(); 
            }
        }
        return getPrice; 
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!isTouching)
        {
            string objText = other.gameObject.GetComponent<TextMeshPro>().text;
            string price = updateText(objText);
            binText.gameObject.GetComponent<TextMeshPro>().text = price; 
            isTouching = true;
        }
        else if (isTouching)
        {
            isTouching = false;
        }
    }
}
