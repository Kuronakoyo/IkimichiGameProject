using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunekune : MonoBehaviour
{
    private int number_2;
    bool KunekuneFlag;

    [SerializeField]
    private GameObject KUNEKUNE;

    void Start()
    {
        KUNEKUNE.SetActive(false);
        KunekuneFlag = false;
    }

    public void OnClick()
    {
        // �w��͈͂̐����������_���ɐ���
        number_2 = Random.Range(0,10);

        // �������P�������ꍇ�t���O��true��
        if (number_2 == 4)
        {
            KunekuneFlag = true;
        }
        // �P�ȊO�̏ꍇ�ʂ̉��ق��o��
        else
        {
            KunekuneFlag = false;
            Debug.Log("����ȊO���o��");
        }

        // �t���O��true�ɂȂ��UMA�o��
        if (KunekuneFlag == true)
        {
            KUNEKUNE.SetActive(true);
            Debug.Log("���˂��ˏo��");
        }

    }
}
