using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Text2 : MonoBehaviour
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
    GameObject Mbbutton;
    [SerializeField]
    GameObject BCbutton;
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
        TextOn();
    }
    public void TextOn()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(TextSet());

        }
        StartCoroutine(TextWait());

    }
    IEnumerator TextSet()
    {
        int textCount = 0;
        telopText.text = "";
        while (textany[textcount].Length > textCount)
        {
            telopText.text += textany[textcount][textCount];
            textCount++;
            yield return new WaitForSeconds(telopSpeed);
        }
        textcount++;
    }
    IEnumerator TextWait()
    {
        if (textcount == 3)
        {
            yield return new WaitForSeconds(1.0f);
            panel.SetActive(false);
            Mbbutton.SetActive(true);
            BCbutton.SetActive(true);
        }

    }
}