using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        
    }


    // ゴールラインに触れたら
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Now")
        {
            Debug.Log("ゴールだよ");
        }
    }


}
