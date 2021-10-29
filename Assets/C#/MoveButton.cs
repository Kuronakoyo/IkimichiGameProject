using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;
    public GameObject movebutton1;
    public GameObject movebutton2;
    public GameObject movebutton3;
    public GameObject movebutton4;
    public GameObject backbutton1;
    public GameObject backbutton2;
    public GameObject backbutton3;
    public GameObject backbutton4;
    public GameObject runbutton5;
    public GameObject runbutton4;
    public GameObject runbutton3;
    public GameObject runbutton2;
    public GameObject runbutton1;
    public GameObject runbutton0;
    public GameObject Myself;
    public GameObject Myself2;
    public GameObject Myself3;
    public GameObject Myself4;
    public int phase = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    public void MoveOnClick()
    {
        if (background1.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself2.SetActive(true);
                Myself.SetActive(false);
                background1.SetActive(false);
                background2.SetActive(true);
                movebutton1.SetActive(false);
                movebutton2.SetActive(true);
                backbutton1.SetActive(false);
                backbutton2.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself3.SetActive(true);
                Myself2.SetActive(false);
                background2.SetActive(false);
                background3.SetActive(true);
                movebutton2.SetActive(false);
                movebutton3.SetActive(true);
                backbutton2.SetActive(false);
                backbutton3.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if(background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself4.SetActive(true);
                Myself3.SetActive(false);
                background3.SetActive(false);
                background4.SetActive(true);
                movebutton3.SetActive(false);
                movebutton4.SetActive(true);
                backbutton3.SetActive(false);
                backbutton4.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
               
            }
        }
    }
    public void MoveOn2Click()
    {
        if (background1.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself2.SetActive(true);
                Myself.SetActive(false);
                background1.SetActive(false);
                background2.SetActive(true);
                movebutton1.SetActive(false);
                movebutton2.SetActive(true);
                backbutton1.SetActive(false);
                backbutton2.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself3.SetActive(true);
                Myself2.SetActive(false);
                background2.SetActive(false);
                background3.SetActive(true);
                movebutton2.SetActive(false);
                movebutton3.SetActive(true);
                backbutton2.SetActive(false);
                backbutton3.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself4.SetActive(true);
                Myself3.SetActive(false);
                background3.SetActive(false);
                background4.SetActive(true);
                movebutton3.SetActive(false);
                movebutton4.SetActive(true);
                backbutton3.SetActive(false);
                backbutton4.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

            }
        }
    }
    public void MoveOn3Click()
    {
        if (background1.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself2.SetActive(true);
                Myself.SetActive(false);
                background1.SetActive(false);
                background2.SetActive(true);
                movebutton1.SetActive(false);
                movebutton2.SetActive(true);
                backbutton1.SetActive(false);
                backbutton2.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself3.SetActive(true);
                Myself2.SetActive(false);
                background2.SetActive(false);
                background3.SetActive(true);
                movebutton2.SetActive(false);
                movebutton3.SetActive(true);
                backbutton2.SetActive(false);
                backbutton3.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                phase++;
                Myself4.SetActive(true);
                Myself3.SetActive(false);
                background3.SetActive(false);
                background4.SetActive(true);
                movebutton3.SetActive(false);
                movebutton4.SetActive(true);
                backbutton3.SetActive(false);
                backbutton4.SetActive(true);
                Debug.Log("クリックしました");
            }
        }
        else if (background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {

            }
        }
    }
    public void SetpBackClick()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Myself2.SetActive(false);
            Myself.SetActive(true);
            Instantiate(movebutton1);
            background1.SetActive(true);
            background2.SetActive(false);
            movebutton1.SetActive(true);
            movebutton2.SetActive(false);
            backbutton1.SetActive(true);
            backbutton2.SetActive(false);
            Debug.Log("戻りました１");
        }
    }
    public void SetpBack2Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Myself3.SetActive(false);
            Myself2.SetActive(true);
            background2.SetActive(true);
            background3.SetActive(false);
            movebutton2.SetActive(true);
            movebutton3.SetActive(false);
            backbutton2.SetActive(true);
            backbutton3.SetActive(false);
            Debug.Log("戻りました2");
        }
    }
    public void SetpBack3Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Myself4.SetActive(false);
            Myself3.SetActive(true);
            background3.SetActive(true);
            background4.SetActive(false);
            movebutton3.SetActive(true);
            movebutton3.SetActive(false);
            backbutton2.SetActive(true);
            backbutton3.SetActive(false);
            Debug.Log("戻りました3");
        }
    }
}
