using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackCat : MonoBehaviour
{
    SpriteRenderer MainCat;

    [SerializeField] Sprite StandCat;   // 普段の猫のスプライト
    [SerializeField] Sprite FrontCat;   // 正面の猫のスプライト
    [SerializeField] Sprite BackCat;    // 後ろ向きの猫のスプライト
    // Start is called before the first frame update
    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainCat = gameObject.GetComponent<SpriteRenderer>();
    }

    // 進退のテスト用
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
    }

    //黒猫の出現
    private void Cat()
    {
        MainCat.sprite = StandCat;  // 普段の向きの猫
        StartCoroutine("CatBig");   // 徐々に大きくなる
    }

    //進んだとき
    private void CatMove()
    {
        MainCat.sprite = FrontCat;  // 正面向きの猫
        StartCoroutine("CatBoice"); // SEが入るところ
        MainCat.sprite = BackCat;   // 後ろ向きの猫
    }

    //下がったとき
    private void CatDown()
    {
        this.transform.localScale = new Vector3(0, 0, 0);   // 消える
    }

    //すっと現れる
    IEnumerator CatBig()
    {
        for(float i = 0; i < 0.5f; i += 0.1f)                   //サイズが0.5になるまで
        {
            this.transform.localScale = new Vector3(i, i, i);   //(i,i,i)の大きさで
            yield return new WaitForSeconds(0.01f);             //0.01秒後に
        }
    }


    //SE:鳴き声
    IEnumerator CatBoice()
    {
        Debug.Log("黒猫と遭遇!!");
        yield return new WaitForSeconds(2f);    //2秒後に
        Debug.Log("ここSE:黒猫が鳴く!!");
    }
}

/*
 【スクリプト内容】
       *黒猫*
    1.「小さく画面中央に表示」　  :sclaeを(0.5,0.5,0.5)で表示

    進
    2-1.「黒猫[正面]の画像に変更」:画像差し替え
    2-2.「一鳴き」                :2秒後SEを入れる+正気度5減少
    2-3.「主人公の進行方向に去る」:黒猫[後ろ向き]に差し替え


    戻
    3-1.「戻る演出が入り黒猫消失」:黒猫消す。Scaleを0にして消す。
    
 */