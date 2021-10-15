using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomUMA : MonoBehaviour
{
    private int number;
    bool UMAFlag;

    [SerializeField]
    private GameObject UMA;

    private void Start()
    {
        UMA.SetActive(false);
        UMAFlag = false;
    }


    //UMA�̓����_���ŏo��
    public void OnClick()
    {
        // �w��͈͂̐����������_���ɐ���
        number = Random.Range(0, 2);

        // �������P�������ꍇ�t���O��true��
        if (number == 1)
        {
            UMAFlag = true;
        }
        // �P�ȊO�̏ꍇ�ʂ̉��ق��o��
        else
        {
            UMAFlag = false;
            Debug.Log("����ȊO���o��");
        }

        // �t���O��true�ɂȂ��UMA�o��
        if (UMAFlag == true)
        {
            UMA.SetActive(true);
            Debug.Log("UMA�o��");
        }

        //print(number);
    }
}
