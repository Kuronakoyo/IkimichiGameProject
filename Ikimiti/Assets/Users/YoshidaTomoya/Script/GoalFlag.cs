using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalFlag : MonoBehaviour
{
    private bool BackFlag = false; // �X�C�b�`

    int BackCount = 0;


    void Start()
    {

    }


    void Update()
    {
        // W�L�[�������ꂽ��iW�L�[�͉��j
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("�i��");
            
            transform.Translate(0.7f, 0f, 0f);
        }

        // S�L�[�������ꂽ��iS�L�[�͉��j
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (BackFlag == false)
            {
                Debug.Log("�߂���");
                // Player���͓̂����Ȃ�
                transform.Translate(-0.7f, 0f, 0f);
                BackCount += 1;
            }
            if (BackCount >= 3)
            {
                Debug.Log("�����o�b�N�ł��Ȃ���");
                BackFlag = true;
            }

        }

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("�S�[������");
        }
    }
}


// �Q�[�W�ƌ��ݒn�ƃS�[��
    // �Q�[�W�i�O�ɐi�񂾂�Q�[�W��i�߂āA���ɖ߂�����Q�[�W��߂��j�����Z�i���܂莩�M�Ȃ��j
        // 3��߂����������߂�͂ł��Ȃ��@�Z
    // ���ݒn�i���ݒn���擾���邾���ł����̂��ȁj�����Z
    // �S�[���i�Q�[�W���E�[�܂œ��B������S�[���\���ł����̂��ȁj