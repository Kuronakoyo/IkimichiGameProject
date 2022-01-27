using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haikeimove : MonoBehaviour
{
    [SerializeField]
    GameObject mbbutton;
    [SerializeField]
    GameObject SAN;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            mbbutton.SetActive(true);
            SAN.SetActive(true);
        }
    }
    
}
