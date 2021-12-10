using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class TextMove : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> background;
    [SerializeField]
    private GameObject image;
    [SerializeField]
    private Button bt;
    [SerializeField]
    GameObject backbt;
    [SerializeField]
    GameObject panel;
    public GameObject cat;
    public GameObject blackcat;
    public GameObject backcat;
    public Slider slider;
    public int movephase = 0;
    private bool isback = false;
    public void OnCilick()
    {
        //現在の画像をアクティブモードをfalseにする
        background[movephase].SetActive(false);
        //現在のシーンを更新する
        movephase++;
        //現在の画像をアクティブモードをtrueにする
        background[movephase].SetActive(true);
        Debug.Log(movephase);
        switch (movephase)
        {
            default:
                break;
            case 1:
                break;
            case 2:
                phese2();
                break;
            case 3:
                phese3();
                break;
            case 4:
                phese4();
                break;
            case 5:
                phese5();
                break;
        }
    }
    public void OnBackbuttonClick()
    {
        if (cat.activeInHierarchy)
        {
            isback = true;
            bt.gameObject.SetActive(false);
            backbt.SetActive(false);
            cat.SetActive(false);
        }

    }
    //スクロールバー
    IEnumerator Bar()
    {
        for (int i = 0; i <= 100; i++)
        {
            //スクロールバーを減らす
            slider.value -= 0.12f / 100;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator Cat()
    {
        bt.interactable = false;
        //黒猫を表示させる
        blackcat.SetActive(true);
        //一秒後
        yield return new WaitForSeconds(1.5f);
        blackcat.SetActive(false);
        backcat.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        backcat.SetActive(false);
        bt.interactable = true;
    }
    //フェーズ１の場合
    void phese1()
    {

    }
    //フェーズ２の場合
    void phese2()
    {
        //黒猫を表示させる
        cat.SetActive(true);
        
    }
    //フェーズ３の場合
    void phese3()
    {
        //もしisbackがオンになったら
        if (isback != true)
        {
            //backボタンを非表示
            backbt.SetActive(false);
            //猫を非表示
            cat.SetActive(false);
            StartCoroutine("Cat");
        }
        //ほか
        else
        {
            //猫非表示させる
            cat.SetActive(false);
        }
    }
    //フェーズ４の場合
    void phese4()
    {
        //もし黒猫が表示させた場合
        if (blackcat.activeInHierarchy)
        {
            //スクロールバーを減らす
            StartCoroutine(Bar());
        }
        //黒猫を非表示させる
        blackcat.SetActive(false);
        //
        
    }
    //フェーズ５の場合
    void phese5()
    {
        //黒猫を非表示させる
        backbt.SetActive(false);
        //ボタンを非表示させる
        bt.interactable = false;
        //２秒後にstartシーンに遷移する
        FadeManager.Instance.LoadScene("Start", 2.0f);
        
    }


}
