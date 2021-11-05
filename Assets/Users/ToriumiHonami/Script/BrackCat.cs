using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackCat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine("CatBig");
            StartCoroutine("CatBoice");
        }
    }

    

    //すっと現れる
    IEnumerator CatBig()
    {
        for(float i = 0; i < 1; i += 0.1f)                      //サイズが1になるまで
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
    1.「暗闇からすっと現れる」  :scale?
    2.「こちらをじっと見つめる」:Animation?
    3.「一鳴き」                :2秒後SEを入れる
    4.「主人公の進行方向に去る」:scale? Animation?
 
 
 */