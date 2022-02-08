using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncomingCall : MonoBehaviour
{
    [SerializeField]
    GameObject _bg;

    [SerializeField]
    GameObject _gameover;

    [SerializeField]
    GameObject _callscreen;

    [SerializeField]
    GameObject _panel;

    [SerializeField]
    GameObject _title;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Incoming()
    {
        StartCoroutine("incoming");
    }

    IEnumerator incoming()
    {
        // ���M��ʂ��\��(���̉摜��킹�Ă���)
        _bg.SetActive(true);

        // 2�b��
        yield return new WaitForSeconds(2.0f);

        // �����w���͂��O���x
        Debug.Log("���͂��O��");     // �؂����

        // SE   ����


        // 3�b��(���Ԓx�߂ł������Ǝv��)
        yield return new WaitForSeconds(3.0f);

        // �S���̉�ʂ��\��
        _bg.SetActive(false);
        _gameover.SetActive(false);
        _panel.SetActive(false);
        _callscreen.SetActive(false);

        // �^�C�g�����(GameOver�p)��\��
        _title.SetActive(true);

    }


}
