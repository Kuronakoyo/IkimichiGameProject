using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
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
    TextMove tm;
    public Slider slider;
    public GameObject cat;
    public GameObject blackcat;
    private bool istextview = false;
    private int textcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        textcount = 0;
        telopText = GetComponentInChildren<Text>();
        StartCoroutine(TextSet());
        tm = GameObject.Find("MoveButtonManager").GetComponent<TextMove>();

    }

    // Update is called once per frame
    void Update()
    {
        TextOn();
    }
    public void TextOn()
    {
        if(Input.GetMouseButtonDown(0) && istextview == false)
        {
            if (tm.movephase != 5)
            {
                StartCoroutine(TextSet());
            }
        }
        TextWait();


    }
    IEnumerator TextSet()
    {
        istextview = true;
        int textCount = 0;
        telopText.text = "";
        while (textany[textcount].Length > textCount)
        {
            telopText.text += textany[textcount][textCount];
            textCount++;
            yield return new WaitForSeconds(telopSpeed);
        }
        textcount++;
        istextview = false;
    }
    void TextWait()
    {
        if (textcount == textany.Count)
        {
            
            panel.SetActive(false);
            Mbbutton.SetActive(true);
            if (cat.gameObject.activeInHierarchy == true)
            {
                slider.gameObject.SetActive(true);
                BCbutton.SetActive(true);
            }
            if (blackcat.gameObject.activeInHierarchy == true)
            {
                slider.gameObject.SetActive(true);
            }
        }
      
    }
}
