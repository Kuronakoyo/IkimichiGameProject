using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Textv : MonoBehaviour
{
    [SerializeField] List<string> messageList = new List<string>();//会話文リスト
    [SerializeField] Text text;
    [SerializeField] float novelSpeed;//一文字一文字の表示する速さ
    int novelListIndex = 0; //現在表示中の会話文の配列


    void Start()
    {
        StartCoroutine(Novel());
    }


    private IEnumerator Novel()
    {
        int messageCount = 0; //現在表示中の文字数
        text.text = ""; //テキストのリセット
        while (messageList[novelListIndex].Length > messageCount)//文字をすべて表示していない場合ループ
        {
            text.text += messageList[novelListIndex][messageCount];//一文字追加
            messageCount++;//現在の文字数
            yield return new WaitForSeconds(novelSpeed);//任意の時間待つ
        }
    }
  }
