using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EyebtnManager : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer _spite;
    [SerializeField]
    Button _button;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Click()
    {
        _button.interactable = false;
        _spite.color =new Color32(0, 0, 0, 255);
    }

}
