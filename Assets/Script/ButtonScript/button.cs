using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // ƒS[ƒ‹ƒ‰ƒCƒ“‚ÉG‚ê‚½‚ç
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Now")
        {
            Debug.Log("ƒS[ƒ‹‚¾‚æ");
        }
    }
}
