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
        // 指定範囲の数字をランダムに生成
        number = Random.Range(0, 2);

        if(KunekuneFlag == false)
        {
            // 数字が4だった場合フラグをtrueに
            if (number == 1)
            {
                KunekuneFlag = true;
            }
            // 4以外の場合別の怪異が出現(仮)
            else
            {
                KunekuneFlag = false;
                Debug.Log("なにも現れなかった...");
            }

            // フラグがtrueになると"くねくね"出現
            if (KunekuneFlag == true)
            {
                KUNEKUNE.SetActive(true);
                Debug.Log("くねくね出現");

                audioSource.PlayOneShot(soundKunekune);
            }
        }

        if(KunekuneFlag == true)
        {
            Debug.Log("'くねくね'の笑い声");
        }
    }

    public void OnDash()
    {
        if(KunekuneFlag == true)
        {
            Debug.Log("'くねくね'の笑い声");
        }
    }

    public void OnSlowMove()
    {
        if(KunekuneFlag == true)
        {
            KUNEKUNE.SetActive(false);
            KunekuneFlag = false;
            Debug.Log("'くねくね'から逃げた");
        }
    }
}
