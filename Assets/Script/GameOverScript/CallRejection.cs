using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallRejection : MonoBehaviour
{
    [SerializeField]
    GameObject _bg;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rejection()
    {
        StartCoroutine("rejection");
    }

    IEnumerator rejection()
    {
        // ���M��ʂ��\��(���̉摜��킹�Ă���)
        _bg.SetActive(true);

        // 3�b��
        yield return new WaitForSeconds(3.0f);

        // SE�@���M��


        // ���M��ʂ�\��
        _bg.SetActive(false);

    }
}
