using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveButton : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> background;
    [SerializeField]
    private Scrollbar scrollbar;
    [SerializeField]
    private Slider slider;
    private static int phase = 0;

    void Start()
    {
        // スライダーを取得する
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }
    public  void ChangeBackground()
    {
        //初期化
        /*for(int i = 0;i < background.Count;i++)
        {

            background[i].SetActive(false);
            
        }*/
        //ホームゲージのバー
        StartCoroutine(Bar());
        //正気度ゲージのバー
        StartCoroutine(SlierBar());
        //現在の画像をアクティブモードをfalseにする
        background[phase].SetActive(false);
        //現在のシーンを更新する
        phase++;
        Debug.Log(phase);
        //現在の画像をアクティブモードをtrueにする
        background[phase].SetActive(true);
        

    }
    /// <summary>
    ///入力した数値に数値の画像に飛ぶ
    /// </summary>
    /// <param name="i">画像の番号</param>
   　public void Skip(int i)
    {
        background[phase].SetActive(false);
        phase = i;
        background[phase].SetActive(true);
    }
    public  int Getphase()
    {
        return phase;
    }
    public void Setphase(int index)
    {
        phase = index;
    }
    IEnumerator SlierBar()
    {
        for (int i = 0; i <= 100; i++)
        {
            slider.value -= 0.12f / 100;
            yield return new WaitForSeconds(0.01f);
        }
    }

   IEnumerator Bar()
    {
        for(int i = 0;i<=100;i++)
        {
            scrollbar.value += 0.12f/100;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
