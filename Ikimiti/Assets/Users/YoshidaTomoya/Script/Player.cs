using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool BackFlag = false; // �X�C�b�`


    void Start()
    {
        
    }


    void Update()
    {
        // W�L�[�������ꂽ��iW�L�[�͉��j
        if(Input.GetKeyDown(KeyCode.W))
        {
            // Player���͓̂����Ȃ�
            transform.Translate(0f, 0f, 0f);


        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            
            if (BackFlag == false)
            {
                // Player���͓̂����Ȃ�
                transform.Translate(0f, 0f, 0f);
            }

        }



    }
}
