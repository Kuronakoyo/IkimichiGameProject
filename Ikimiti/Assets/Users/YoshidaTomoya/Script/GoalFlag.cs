using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalFlag : MonoBehaviour
{
    public bool BackFlag = false; // �X�C�b�`
    public bool StartFlag = false; // �X�C�b�`

    int BackCount = 3;  // ���ɖ߂��c��̉�
    int StartCount = 1;


    void Start()
    {

    }


    void Update()
    {
        // W�L�[�������ꂽ��iW�L�[�͉��j
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (StartCount == 0)
            {
                transform.Translate(0f, 0f, 0f);
            }

            transform.Translate(7f, 0f, 0f);


        }


        // S�L�[�������ꂽ��iS�L�[�͉��j
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (BackFlag == false)
            {
                // Player���͓̂����Ȃ�
                transform.Translate(-7f, 0f, 0f);
                BackCount -= 1;
            }
            if (BackCount <= 0)
            {
                Debug.Log("�����o�b�N�ł��Ȃ���");
                BackFlag = true;
            }

        }

    }


    // �Q�[�W�̉E�[�ɒ������炻��ȍ~�i�߂Ȃ��悤�ɂ���
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            StartFlag = true;
            StartCount = 0;
        }
    }

    // �ŏ��̓Q�[�W�����ɉ�����Ȃ��悤�ɂ���
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Start")
        {
            BackCount = 0;
            BackFlag = true;
        }


    }

    // �Q�[�W�̍��[�ɂ��Ȃ���������ɖ߂��悤�ɂ���
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Start")
        {
            BackFlag = false;
            BackCount = 3;
        }
    }


}


// �Q�[�W�ƌ��ݒn�ƃS�[��
    // �Q�[�W�i�O�ɐi�񂾂�Q�[�W��i�߂āA���ɖ߂�����Q�[�W��߂��j�����Z�i���܂莩�M�Ȃ��j
        // 3��߂����������߂�͂ł��Ȃ��@�Z
    // ���ݒn�i���ݒn���擾���邾���ł����̂��ȁj�����Z
    // �S�[���i�Q�[�W���E�[�܂œ��B������S�[���\���ł����̂��ȁj