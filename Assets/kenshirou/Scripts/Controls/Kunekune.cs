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
        // 指定範囲の数字をランダムに生成
        number_2 = Random.Range(0,10);

        // 数字が１だった場合フラグをtrueに
        if (number_2 == 4)
        {
            KunekuneFlag = true;
        }
        // １以外の場合別の怪異が出現
        else
        {
            KunekuneFlag = false;
            Debug.Log("それ以外が出現");
        }

        // フラグがtrueになるとUMA出現
        if (KunekuneFlag == true)
        {
            KUNEKUNE.SetActive(true);
            Debug.Log("くねくね出現");
        }

    }
}
