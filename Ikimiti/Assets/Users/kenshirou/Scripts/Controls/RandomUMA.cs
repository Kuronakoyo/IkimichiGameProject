using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomUMA : MonoBehaviour
{
    private int number;
    public bool UMAFlag;

    [SerializeField]
    private GameObject UMA;

    public AudioClip soundUMA;
    AudioSource audioSource;

    private void Start()
    {
        UMA.SetActive(false);
        UMAFlag = false;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {

    }

    //UMA�̓����_���ŏo��
    public void OnClick()
    {
        // �w��͈͂̐����������_���ɐ���
        number = Random.Range(0, 2);

        if(UMAFlag == false)
        {
            // �������P�������ꍇ�t���O��true��
            if (number == 1)
            {
                UMAFlag = true;
            }
            // �P�ȊO�̏ꍇ�����Ȃ�(��)
            else
            {
                UMAFlag = false;
                Debug.Log("�Ȃɂ�����Ȃ�����...");
            }

            // �t���O��true�ɂȂ��UMA�o��
            if (UMAFlag == true)
            {
                UMA.SetActive(true);
                Debug.Log("UMA�o��");

                audioSource.PlayOneShot(soundUMA);
            }
        }

        if(UMAFlag == true)
        {
            Debug.Log("'UMA'����Ȃ���������Ă���");
        }
    }

    public void OnDash()
    {
        if (UMAFlag == true)
        {
            UMA.SetActive(false);
            UMAFlag = false;
            Debug.Log("'UMA'���瓦����");
        }
    }

    public void OnSlowMove()
    {
       if(UMAFlag == true)
       {
            Debug.Log("'UMA'����Ȃ���������Ă���");
       }
    }
}
