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


    // ƒS[ƒ‹ƒ‰ƒCƒ“‚ÉG‚ê‚½‚ç
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Now")
        {
            Debug.Log("ƒS[ƒ‹‚¾‚æ");
        }
    }


}
