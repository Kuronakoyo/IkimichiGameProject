using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalFlag : MonoBehaviour
{
    public bool BackFlag = false; // スイッチ
    public bool StartFlag = false; // スイッチ

    int StartCount = 1;


    void Start()
    {

    }


    void Update()
    {
        // Wキーが押されたら（Wキーは仮）
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (StartCount == 0)
            {
                // 一番右にいたら進まない
                transform.Translate(0f, 0f, 0f);
            }
            else
            {
                // 右に進む
                Debug.Log("進んでるよ");
                transform.Translate(0.7f, 0f, 0f);
            }


        }


        // Sキーが押されたら（Sキーは仮）
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Sキーが押されても戻らない
            transform.Translate(-0f, 0f, 0f);
            Debug.Log("戻らないよ");

        }

    }


    // ゲージの右端に着いたらそれ以降進めないようにする
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            StartFlag = true;
            StartCount = 0;
        }
    }

    // 最初はゲージが後ろに下がれないようにする
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Start")
        {
            BackFlag = true;
        }


    }

    // ゲージの左端にいなかったら後ろに戻れるようにする
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Start")
        {
            BackFlag = false;
        }
    }


}


// ゲージと現在地とゴール
    // ゲージ（前に進んだらゲージを進めて、後ろに戻ったらゲージを戻す）多分〇（あまり自信ない）
        // 3回戻ったらもう後戻りはできない　〇
    // 現在地（現在地を取得するだけでいいのかな）多分〇
    // ゴール（ゲージが右端まで到達したらゴール表示でいいのかな）