using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;
    public GameObject Myself;
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
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(background2);
            background1.SetActive(false);
            background2.SetActive(true);
            //Myself.transform.position(5.0f, 0.0f, 0.0f);
            Debug.Log("åƒÇ—èoÇµÇΩ");
        }
    }
    public void SetpBackClick()
    {
        if (Input.GetMouseButtonDown(0))
        {

            
            
        }
    }
}
