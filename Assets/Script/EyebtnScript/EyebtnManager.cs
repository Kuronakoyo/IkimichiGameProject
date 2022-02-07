using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EyebtnManager : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer _spite;
    [SerializeField]
    private Button _button;

    private bool _isCloseEye = false;
    public bool IsCloseEye => _isCloseEye;
    private bool _isClickOnce = false;
    public bool IsClickOnce => _isClickOnce;

    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(Click);
    }

    /// <summary>
    /// Day が更新されるたびに最初に１度呼び出される
    /// </summary>
    public void Setup()
    {
        _isCloseEye = false;
        _isClickOnce = false;
    }

    /// <summary>
    /// ボタンを押した最初の移動後に呼び出される
    /// </summary>
    public void SetClickOnce()
    {
        _isClickOnce = true;
    }

    /// <summary>
    /// EYE ボタンを押したら呼び出される
    /// </summary>
    public void Click()
    {
        _isCloseEye = true;
        _button.interactable = false;
    }


}
