using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText4 : MonoBehaviour
{
    [SerializeField]
    List<string> textList = new List<string>();
    [SerializeField]
    Text text;
    [SerializeField]
    float textSpeed;
    int textListIndex = 0;
    private bool NextText = true;
    public TutorialManager tutorialmanager;
    public GameObject manager;
    public Image backcat;
    private bool judge = true;
    private bool judge2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("flag");
        text = GetComponent<Text>();
        backcat = GameObject.Find("backcat").GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (tutorialmanager.flag5 == true)
        {
            if (judge2 == false)
            {
                StartCoroutine(Delay());
            }
            if (judge2 == true)
            {
                if (judge == true)
                {
                    text.enabled = true;
                    StartCoroutine(Novel());
                    judge = false;
                }
                if (Input.GetKey(KeyCode.Space) && !NextText && (textListIndex < textList.Count))
                {
                    NextText = true;
                    StartCoroutine(Novel());
                }
                else if (Input.GetKey(KeyCode.Space) && !NextText && !(textListIndex < textList.Count))
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
    private IEnumerator Novel()
    {
        int textCount = 0;
        text.text = "";
        while (textList[textListIndex].Length > textCount)
        {
            Debug.Log("a");
            text.text += textList[textListIndex][textCount];
            textCount++;
            yield return new WaitForSeconds(textSpeed);
        }
        textListIndex++;
        NextText = false;
    }
    private IEnumerator Delay()
    {
        backcat.enabled = true;
        Debug.Log("待ってまーす");
        yield return new WaitForSeconds(2);
        Debug.Log("終わり");
        backcat.enabled = false;
        judge2 = true;
    }
}
