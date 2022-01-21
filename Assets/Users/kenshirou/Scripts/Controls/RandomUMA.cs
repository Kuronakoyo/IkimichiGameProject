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

    //UMAはランダムで出現
    public void OnClick()
    {
        // 指定範囲の数字をランダムに生成
        number = Random.Range(0, 2);

        if(UMAFlag == false)
        {
            // 数字が１だった場合フラグをtrueに
            if (number == 1)
            {
                UMAFlag = true;
            }
            // １以外の場合何もなし(仮)
            else
            {
                UMAFlag = false;
                Debug.Log("なにも現れなかった...");
            }

            // フラグがtrueになるとUMA出現
            if (UMAFlag == true)
            {
                UMA.SetActive(true);
                Debug.Log("UMA出現");

                audioSource.PlayOneShot(soundUMA);
            }
        }

        if(UMAFlag == true)
        {
            Debug.Log("'UMA'が呻きながら向かってくる");
        }
    }

    public void OnDash()
    {
        if (UMAFlag == true)
        {
            UMA.SetActive(false);
            UMAFlag = false;
            Debug.Log("'UMA'から逃げた");
        }
    }

    public void OnSlowMove()
    {
       if(UMAFlag == true)
       {
            Debug.Log("'UMA'が呻きながら向かってくる");
       }
    }
}
