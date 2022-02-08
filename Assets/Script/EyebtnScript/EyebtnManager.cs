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
    /// Day ���X�V����邽�тɍŏ��ɂP�x�Ăяo�����
    /// </summary>
    public void Setup()
    {
        _isCloseEye = false;
        _isClickOnce = false;
    }

    /// <summary>
    /// �{�^�����������ŏ��̈ړ���ɌĂяo�����
    /// </summary>
    public void SetClickOnce()
    {
        _isClickOnce = true;
    }

    /// <summary>
    /// EYE �{�^������������Ăяo�����
    /// </summary>
    public void Click()
    {
        _isCloseEye = true;
        _button.interactable = false;
    }


}
