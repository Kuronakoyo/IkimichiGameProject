using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool BackFlag = false; // スイッチ


    void Start()
    {
        
    }


    void Update()
    {
        // Wキーが押されたら（Wキーは仮）
        if(Input.GetKeyDown(KeyCode.W))
        {
            // Player自体は動かない
            transform.Translate(0f, 0f, 0f);


        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            
            if (BackFlag == false)
            {
                // Player自体は動かない
                transform.Translate(0f, 0f, 0f);
            }

        }



    }
}
