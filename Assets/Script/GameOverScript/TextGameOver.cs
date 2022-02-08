using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextGameOver : MonoBehaviour
{
    [SerializeField]
    List<string> textany = new List<string>();
    [SerializeField]
    Text telopText;
    [SerializeField]
    float telopSpeed;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject san;
    public GameObject mbbtnday4;
    private bool istextview = false;
    private int textcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        textcount = 0;
        telopText = GetComponentInChildren<Text>();
        StartCoroutine(TextSet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TextOn()
    {
       
    }
    void TextHide()
    {
        
      
    }
    IEnumerator TextSet()
    {
        istextview = true;
        int textCCCCC = 0;
        telopText.text = "";
        while (textany[textcount].Length > textCCCCC)
        {
            telopText.text += textany[textcount][textCCCCC];
            textCCCCC++;
            yield return new WaitForSeconds(telopSpeed);
        }
        textcount++;
        istextview = false;
    }

}
