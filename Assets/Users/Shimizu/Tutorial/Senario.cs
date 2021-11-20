using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senario : MonoBehaviour
{
    
    public class ScenarioModel
    {
        //現在選択中の行番号
        public int nowSelectline = 0;
        // シナリオを配列で保存する
        public string[] scenario;
        // 最大行数の取得
        public int MaxLineCount { get { return scenario.Length; } }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
