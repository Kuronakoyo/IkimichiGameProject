using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool BackFlag = false; // �X�C�b�`

    int BackCount = 0;

    void Start()
    {
        
    }


    void Update()
    {
        // W�L�[�������ꂽ��iW�L�[�͉��j
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("�i��");
            // Player���͓̂����Ȃ�
            transform.Translate(0f, 0f, 0f);


        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            
            if (BackFlag == false)
            {
                Debug.Log("�߂���");
                // Player���͓̂����Ȃ�
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
