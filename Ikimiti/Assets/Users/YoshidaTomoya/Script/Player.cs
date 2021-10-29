using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool BackFlag = false; // スイッチ

    int BackCount = 0;

    void Start()
    {
        
    }


    void Update()
    {
        // Wキーが押されたら（Wキーは仮）
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("進んだ");
            // Player自体は動かない
            transform.Translate(0f, 0f, 0f);


        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            
            if (BackFlag == false)
            {
                Debug.Log("戻った");
                // Player自体は動かない
                transform.Translate(0f, 0f, 0f);
                BackCount += 1;
            }
            if (BackCount >= 3)
            {
                BackFlag = true;
            }

        }



    }
}
