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
    GameObject panel;
    [SerializeField]
    GameObject panel2;
    [SerializeField]
    GameObject panel3;
    [SerializeField]
    GameObject bt;
    [SerializeField]
    GameObject backbt;
    public GameObject cat;
    public GameObject blackcat;
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
            panel3.SetActive(true);
            bt.gameObject.SetActive(false);
            backbt.SetActive(false);
            cat.SetActive(false);
        }

    }
    IEnumerator Bar()
    {
        for (int i = 0; i <= 100; i++)
        {
            slider.value -= 0.12f / 100;
            yield return new WaitForSeconds(0.01f);
        }
    }
    void phese1()
    {

    }
    void phese2()
    {
        cat.SetActive(true);
        panel.SetActive(true);
        bt.gameObject.SetActive(false);
    }
    void phese3()
    {
        if (isback != true)
        {
            panel2.SetActive(true);
            bt.gameObject.SetActive(false);
            backbt.SetActive(false);
            cat.SetActive(false);
            blackcat.SetActive(true);
        }
        else
        { 
            cat.SetActive(false);
            
        }
    }
    void phese4()
    {
        if (blackcat.activeInHierarchy)
        {
            StartCoroutine(Bar());
        }
        blackcat.SetActive(false);
       
    }
     void phese5()
    {
        backbt.SetActive(false);
        bt.SetActive(false);
        FadeManager.Instance.LoadScene("Start", 2.0f);
        
    }


}
