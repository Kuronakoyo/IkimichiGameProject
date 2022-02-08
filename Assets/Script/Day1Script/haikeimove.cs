using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haikeimove : MonoBehaviour
{
    [SerializeField]
    GameObject sousaop2;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            sousaop2.SetActive(true);
        }
    }
    
}
