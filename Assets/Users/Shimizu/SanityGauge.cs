using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityGauge : MonoBehaviour
{
    
    //san値の減る値
    [SerializeField]
    private float enemy1;
    [SerializeField]
    private float enemy2;
    [SerializeField]
    private float enemy3;
    [SerializeField]
    private float enemy4;
    [SerializeField]
    private float enemy5;

    public TutorialManager tutorialmanager;
    private float gauge = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //仕様が上がって来次第追加・修正
        if (tutorialmanager.flag6 == true)
        {
            Debug.Log("a");
            GetComponent<Image>().fillAmount = gauge - enemy1;
            gauge = GetComponent<Image>().fillAmount;
            tutorialmanager.flag6 = false;
        }
        if (false)
        {
            Debug.Log("b");
            GetComponent<Image>().fillAmount = gauge - enemy2;
            gauge = GetComponent<Image>().fillAmount;
        }
        if (false)
        {
            Debug.Log("c");
            GetComponent<Image>().fillAmount = gauge - enemy3;
            gauge = GetComponent<Image>().fillAmount;
        }
        if (false)
        {
            Debug.Log("d");
            GetComponent<Image>().fillAmount = gauge - enemy4;
            gauge = GetComponent<Image>().fillAmount;
        }
        if (false)
        {
            Debug.Log("e");
            GetComponent<Image>().fillAmount = gauge - enemy5;
            gauge = GetComponent<Image>().fillAmount;
        }
        if(GetComponent<Image>().fillAmount <= 0)
        {
            Debug.Log("ゲームオーバー");
        }
    }
    
}
