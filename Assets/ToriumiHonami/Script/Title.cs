using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    [SerializeField] GameObject LockScreen; // ロック画面のオブジェクト
   
    [SerializeField] float speed = 5;       // 移動速度

    float Height_max = 1920;                // 画面端の長さ

    private bool isMove;                    // ロック画面が上がるフラグ

    void Start()
    {

    }

    void Update()
    {
        Vector2 pos = LockScreen.transform.position;
    
        // ロック画面の上がる処理

        if (isMove)
        {
            pos.y = Mathf.Lerp(LockScreen.transform.position.y, Height_max, speed * Time.deltaTime);   // 現在の座標から、画面の一番端(1920)までの距離を移動。

            LockScreen.transform.position = pos;
        }
    }

    // ロック画面のスクリプト
    public void Lock()
    {
        isMove = true;
        Invoke("LoadEndingScene", 1.9f);
    }
    void LoadEndingScene()
    {
        SceneManager.LoadScene("ChatScene");
    }
}
/* スクリプト内容 */

// boolで起動
// 画面端(1920) まで移動
// 速度はiPhoneを持っていないので動画を見た結果このくらい

// EventTriggerを使ってクリック判定を入れています。
// Colliderの範囲を設定することでタップできる範囲を決めることができます。

/* 流れ */

// 1. ゲーム起動後ロック画面
// →ロック画面の実装
//
// 2.ロックを解除後すぐにLINEのホーム画面へ

//////////　ここまで　//////////

// 3.新着のついているミス研をタップする
// →ミス研のみタップできるように設定
//
// 4.トーク画面が開く
// →Scene変更？