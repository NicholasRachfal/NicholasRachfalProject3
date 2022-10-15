using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lookAtCamera : MonoBehaviour
{
    // Set these in the editor, or in code.
    //transforms
    public Transform bannerLookTarget;
    public Transform bannerDolly;
    //banner text component
    public TMP_Text tmp_text_banner;

    // Start is called before the first frame update
    void Start()
    {
        tmp_text_banner = GetComponent<TextMeshPro>(); 
        bannerLookTarget = Camera.main.transform;
        InvokeRepeating("Update", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        tmp_text_banner.transform.rotation = Quaternion.LookRotation(tmp_text_banner.transform.position - bannerLookTarget.position);
    }
}
