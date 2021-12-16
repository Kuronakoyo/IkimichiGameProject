using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineHome : MonoBehaviour
{

    [SerializeField] GameObject LineScreen; // lLINEのホームのオブジェクト

    void Start()
    {
        
    }

    void Update()
    {
        
    }


    // LINEのホーム画面のスクリプト
    public void Home()
    {
        SceneManager.LoadScene("ChatScene");
        Debug.Log("トーク画面へ移動");
    }
}
/* スクリプト内容 */

// EventTriggerを使ってクリック判定を入れています。
// Colliderの範囲を設定することでタップできる範囲を決めることができます。


/* 流れ */

// 1. ゲーム起動後ロック画面に
// →ロック画面の実装

// 2.ロックを解除後すぐにLINEのホーム画面へ

//////////　ここから　//////////

// 3.新着のついているミス研をタップする
// →ミス研のみタップできるように設定

//////////　ここまで　//////////

// 4.トーク画面が開く
// →Scene変更？