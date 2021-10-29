using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalFlag : MonoBehaviour
{
    private bool BackFlag = false; // スイッチ

    int BackCount = 0;


    void Start()
    {

    }


    void Update()
    {
        // Wキーが押されたら（Wキーは仮）
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("進んだ");
            
            transform.Translate(0.7f, 0f, 0f);
        }

        // Sキーが押されたら（Sキーは仮）
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (BackFlag == false)
            {
                Debug.Log("戻った");
                // Player自体は動かない
                transform.Translate(-0.7f, 0f, 0f);
                BackCount += 1;
            }
            if (BackCount >= 3)
            {
                Debug.Log("もうバックできないよ");
                BackFlag = true;
            }

        }

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Debug.Log("ゴールだよ");
        }
    }
}


// ゲージと現在地とゴール
    // ゲージ（前に進んだらゲージを進めて、後ろに戻ったらゲージを戻す）多分〇（あまり自信ない）
        // 3回戻ったらもう後戻りはできない　〇
    // 現在地（現在地を取得するだけでいいのかな）多分〇
    // ゴール（ゲージが右端まで到達したらゴール表示でいいのかな）