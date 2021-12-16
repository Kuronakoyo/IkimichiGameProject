using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Main : MonoBehaviour
{
    [SerializeField]
    private int _MaxText;
    private Text _text;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        //テキストのコンポーネントを取得する
        _text = transform.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            
        }
       
    }
    /*
    IEnumerator Textview()
    {
        //string st[];
        for (int i = 0;i > _text.text.Length -1;i++)
        {
            //st[i] = _text.text[i].ToString();
        }
        
    }
    */
    /*
    void TextOn()
    {
        for(int i = 0)
        {

        }
    }
    */
}
