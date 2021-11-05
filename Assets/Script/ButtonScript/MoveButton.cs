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
    [SerializeField]
    private Button movebtn;
    [SerializeField]
    private Button runbtn;
    [SerializeField]
    private Button walkbtn;
    private static int phase = 0;
    public int runbtncount = 0;
 
    void Start()
    {
        phase = 0;
        // スライダーを取得する
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        runbtncount = 5;

    }
    public void ChangeBackground()
    {
       
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
            //もし画像が最後になったらゲームオーバーシーンに移行する
            if (phase == 9)
            {
                FadeManager.Instance.LoadScene("GameOver", 2.0f);
            }
            //クリックしたらmoveボタンを非表示させる
            movebtn.interactable = false;
            //クリックしたらrunボタンを非表示させる
            runbtn.interactable = false;
            //クリックしたらwalkボタンを非表示させる
            walkbtn.interactable = false;
            StartCoroutine(ButtonOn());

           

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
    public int Getphase()
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
        for (int i = 0; i <= 100; i++)
        {
            scrollbar.value += 0.12f / 100;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator ButtonOn()
    {
        yield return new WaitForSeconds(1.8f);
        movebtn.interactable = true;
        walkbtn.interactable = true;
        
        if(runbtncount == 0)
        {
            runbtn.interactable = false;
        }
        else 
        {
            runbtn.interactable = true;
        }


    }
    
}