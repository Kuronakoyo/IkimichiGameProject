using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoTuning : MonoBehaviour
{
    private float HorizontalPosion = 30;
    //
    private float VerticalPosion = -85;
   
    
    //
    private int MaxLineSize = 14;

    private const int _width = 830;

    private const int _height = 80;
    private RectTransform rect;
    private Transform Parent;
    private Text _text;
    void Awake()
    {
        _text = transform.GetComponent<Text>();
        Parent = transform.parent.transform;
        rect = transform.GetComponent<RectTransform>();
    }
    void Start()
    {
        HorizontalPosion = rect.localPosition.x;
        VerticalPosion = rect.localPosition.y;
        rect.localPosition = new Vector2(HorizontalPosion, VerticalPosion);
        //SizeView();
        kkkk();
    }
    void SizeView()
    {
        float line = transform.GetComponent<Text>().text.Length /(float)MaxLineSize;
        Parent.GetComponent<RectTransform>().sizeDelta = new Vector2(_width, _height * Mathf.Ceil(line));
        Debug.Log(line);
        Debug.Log(Mathf.Ceil(line));
    } 
    void kkkk()
    {
        rect.sizeDelta = new Vector2(rect.sizeDelta.x, _text.fontSize * Mathf.Ceil(_text.text.Length / (float)MaxLineSize));
    }
}
