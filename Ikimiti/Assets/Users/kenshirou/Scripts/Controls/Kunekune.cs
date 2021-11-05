using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunekune : MonoBehaviour
{
    private int number;
    bool KunekuneFlag;

    [SerializeField]
    private GameObject KUNEKUNE;

    public AudioClip soundKunekune;
    AudioSource audioSource;

    void Start()
    {
        KUNEKUNE.SetActive(false);
        KunekuneFlag = false;
    }
    public void OnMove()
    {
        // �w��͈͂̐����������_���ɐ���
        number = Random.Range(0, 2);

        if(KunekuneFlag == false)
        {
            // ������4�������ꍇ�t���O��true��
            if (number == 1)
            {
                KunekuneFlag = true;
            }
            // 4�ȊO�̏ꍇ�ʂ̉��ق��o��(��)
            else
            {
                KunekuneFlag = false;
                Debug.Log("�Ȃɂ�����Ȃ�����...");
            }

            // �t���O��true�ɂȂ��"���˂���"�o��
            if (KunekuneFlag == true)
            {
                KUNEKUNE.SetActive(true);
                Debug.Log("���˂��ˏo��");

                audioSource.PlayOneShot(soundKunekune);
            }
        }

        if(KunekuneFlag == true)
        {
            Debug.Log("'���˂���'�̏΂���");
        }
    }

    public void OnDash()
    {
        if(KunekuneFlag == true)
        {
            Debug.Log("'���˂���'�̏΂���");
        }
    }

    public void OnSlowMove()
    {
        if(KunekuneFlag == true)
        {
            KUNEKUNE.SetActive(false);
            KunekuneFlag = false;
            Debug.Log("'���˂���'���瓦����");
        }
    }
}
