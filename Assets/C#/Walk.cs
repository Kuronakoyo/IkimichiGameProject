using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public GameObject playerwalk;
    public GameObject runbutton5;
    public GameObject runbutton4;
    public GameObject runbutton3;
    public GameObject runbutton2;
    public GameObject runbutton1;
    public GameObject runbutton0;
    public GameObject kunekune;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playwalk()
    {
        if(kunekune == true)
        {
            playerwalk.SetActive(true);
        }
    }
    public void Runbutton5()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }

    }
}
