using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senario : MonoBehaviour
{
    
    public class ScenarioModel
    {
        //���ݑI�𒆂̍s�ԍ�
        public int nowSelectline = 0;
        // �V�i���I��z��ŕۑ�����
        public string[] scenario;
        // �ő�s���̎擾
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
