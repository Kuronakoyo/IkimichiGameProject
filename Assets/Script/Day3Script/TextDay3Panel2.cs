using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextDay3Panel2 : MonoBehaviour
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
    GameObject panel2;
    [SerializeField]
    GameObject san;
    [SerializeField]
    GameObject Mbbutton;
    public GameObject ENDbutton;
    public GameObject mbbtnday4;
    private bool istextview = false;
    private int textcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        textcount = 0;
        telopText = GetComponentInChildren<Text>();
        StartCoroutine(TextSet());
        SoundManager.Instance.Play_SE(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        TextOn();
    }
    public void TextOn()
    {
        if (Input.GetMouseButtonDown(0) && istextview == false)
        {
            TextHide();
        }
    }
    void TextHide()
    {
        panel2.SetActive(false);
        Mbbutton.SetActive(true);
        san.SetActive(true);
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
