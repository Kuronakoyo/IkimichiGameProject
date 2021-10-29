using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public GameObject playerrun;
    public GameObject enemy;
    public MoveButton mb;
    // Start is called before the first frame update
    void Start()
    {
        mb = mb.GetComponent<MoveButton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Runbutton5()
    {

        if (mb.background1.activeInHierarchy == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                mb.background1.SetActive(false);
                mb.background2.SetActive(true);
                mb.background3.SetActive(false);
                mb.background4.SetActive(false);
                mb.runbutton5.SetActive(false);
                mb.runbutton4.SetActive(true);
                Debug.Log("走りました5");
            }
            
        }
        else if (mb.background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background2.SetActive(false);
                mb.background3.SetActive(true);
                mb.background4.SetActive(false);
                mb.runbutton5.SetActive(false);
                mb.runbutton4.SetActive(true);
                Debug.Log("走りました5第二バージョン");
            }
        }
        else if (mb.background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background3.SetActive(false);
                mb.background4.SetActive(true);
                mb.runbutton5.SetActive(false);
                mb.runbutton4.SetActive(true);
                Debug.Log("走りました5第三バージョン");
            }
        }
        else if (mb.background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background4.SetActive(false);
                mb.runbutton5.SetActive(false);
                mb.runbutton4.SetActive(true);
                Debug.Log("走りました5第四バージョン");
            }
        }
    }
    public void Runbtton4()
    {
        if (mb.background1.activeInHierarchy == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                mb.background1.SetActive(false);
                mb.background2.SetActive(true);
                mb.background3.SetActive(false);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4");
            }

        }
        else if (mb.background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background2.SetActive(false);
                mb.background3.SetActive(true);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第二バージョン");
            }
        }
        else if (mb.background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background3.SetActive(false);
                mb.background4.SetActive(true);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第三バージョン");
            }
        }
        else if (mb.background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第四バージョン");
            }
        }
    }
    public void Runbtton3()
    {
        if (mb.background1.activeInHierarchy == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                mb.background1.SetActive(false);
                mb.background2.SetActive(true);
                mb.background3.SetActive(false);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4");
            }

        }
        else if (mb.background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background2.SetActive(false);
                mb.background3.SetActive(true);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第二バージョン");
            }
        }
        else if (mb.background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background3.SetActive(false);
                mb.background4.SetActive(true);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第三バージョン");
            }
        }
        else if (mb.background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第四バージョン");
            }
        }
    }
    public void Runbtton2()
    {
        if (mb.background1.activeInHierarchy == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                mb.background1.SetActive(false);
                mb.background2.SetActive(true);
                mb.background3.SetActive(false);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4");
            }

        }
        else if (mb.background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background2.SetActive(false);
                mb.background3.SetActive(true);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第二バージョン");
            }
        }
        else if (mb.background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background3.SetActive(false);
                mb.background4.SetActive(true);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第三バージョン");
            }
        }
        else if (mb.background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第四バージョン");
            }
        }
    }
    public void Runbtton1()
    {
        if (mb.background1.activeInHierarchy == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                mb.background1.SetActive(false);
                mb.background2.SetActive(true);
                mb.background3.SetActive(false);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4");
            }

        }
        else if (mb.background2.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background2.SetActive(false);
                mb.background3.SetActive(true);
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第二バージョン");
            }
        }
        else if (mb.background3.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background3.SetActive(false);
                mb.background4.SetActive(true);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第三バージョン");
            }
        }
        else if (mb.background4.activeInHierarchy == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mb.background4.SetActive(false);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
                Debug.Log("走りました4第四バージョン");
            }
        }
    }
    public void Runbtton0()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (mb.background1 == true)
            {
                mb.background2.SetActive(true);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
            }
            if (mb.background2 == true)
            {
                mb.background3.SetActive(true);
                mb.runbutton5.SetActive(false);
                mb.runbutton4.SetActive(true);
            }
            if (mb.background3 == true)
            {
                mb.background4.SetActive(true);
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
            }
            if (mb.background4 == true)
            {
                mb.runbutton4.SetActive(false);
                mb.runbutton3.SetActive(true);
            }
            Debug.Log("走りました");
        }
    }
}
