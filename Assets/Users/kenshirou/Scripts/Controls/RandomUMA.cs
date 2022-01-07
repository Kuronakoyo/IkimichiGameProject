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


    //UMAはランダムで出現
    public void OnClick()
    {
        // 指定範囲の数字をランダムに生成
        number = Random.Range(0, 2);

        // 数字が１だった場合フラグをtrueに
        if (number == 1)
        {
            UMAFlag = true;
        }
        // １以外の場合別の怪異が出現
        else
        {
            UMAFlag = false;
            Debug.Log("それ以外が出現");
        }

        // フラグがtrueになるとUMA出現
        if (UMAFlag == true)
        {
            UMA.SetActive(true);
            Debug.Log("UMA出現");
        }

        //print(number);
    }
}
