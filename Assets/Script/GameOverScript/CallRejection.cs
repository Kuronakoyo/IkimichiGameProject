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
        // 着信画面を非表示(黒の画像を被せている)
        _bg.SetActive(true);

        // 3秒後
        yield return new WaitForSeconds(3.0f);

        // SE　着信音


        // 着信画面を表示
        _bg.SetActive(false);

    }
}
