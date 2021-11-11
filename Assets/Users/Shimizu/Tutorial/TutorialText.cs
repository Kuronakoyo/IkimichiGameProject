using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour
{
    [SerializeField]
    List<string> textList = new List<string>();
    [SerializeField]
    Text text;
    [SerializeField]
    float textSpeed;
    [SerializeField]
    RectTransform rtf;
    private RectTransform rg;

    int textListIndex = 0;
    private bool NextText = true;
    public GameObject manager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //実行したら文字がテキストボックスの左上に表示される
        rg=this.GetComponent<RectTransform>();
        rg.localPosition = rtf.localPosition;
        manager = GameObject.Find("flag");
        StartCoroutine(Novel());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)&& !NextText && (textListIndex < textList.Count))
        {
            NextText = true;
            StartCoroutine(Novel());
        }
        else if(Input.GetKey(KeyCode.Space) && !NextText && !(textListIndex < textList.Count))
        {
            
            manager.GetComponent<TutorialManager>().Flag1();
            Destroy(this.gameObject);
           
        }
    }
    private IEnumerator Novel()
    {
        int textCount = 0;
        text.text = "";
        while(textList[textListIndex].Length > textCount)
        {
            Debug.Log("a");
            text.text += textList[textListIndex][textCount];
            textCount++;
            yield return new WaitForSeconds(textSpeed);
        }
        textListIndex++;
        NextText = false;
    }
}
