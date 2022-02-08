using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverClick : MonoBehaviour
{
    [SerializeField]
    GameObject Panelfade;       // フェードパネルの取得

    public float speed = 0.01f; // 透明化の速さ

    private float alpha;        // α値を操作するための変数

    private bool fadeFlag;      // フェードインのフラグ

    Image fadealpha;            // フェードパネルのイメージ取得変数

    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>();    // パネルのイメージ取得
        alpha = fadealpha.color.a;                      // パネルのα値を取得
        fadeFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeFlag == true)
        {
            FadeIn();
        }
    }
 
    void FadeIn()
    {
        alpha -= speed;
        fadealpha.color = new Color(0, 0, 0, alpha);

        if(alpha <= 0)
        {
            fadeFlag = false;
            Panelfade.SetActive(false);
        }
    }

    
}
