using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MoveBtnDay3 : MonoBehaviour
{
    
    [SerializeField, Header("�G�l�~�[�摜")]
    //UMA
    GameObject _uma;
    [SerializeField]
    GameObject _uma2;
    //���˂���
    [SerializeField]
    GameObject _kunekune;
    //�������˂���
    [SerializeField]
    GameObject _farkunekune;
    //�s�R��
    [SerializeField]
    GameObject _Sp;
    //�����s�R��
    [SerializeField]
    GameObject _farSp;
    //�L
    [SerializeField]
    GameObject _cat;
    //����
    [SerializeField]
    GameObject _sandstorm;
    //����I���{�^��
    [SerializeField]
    GameObject endbtn;
    //move�{�^��
    [SerializeField]
    Button _movebtn;
    [SerializeField]
    GameObject movebutton;
    [SerializeField]
    GameObject san;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    Slider slider;
    [SerializeField]
    private EyebtnManager _eyebtnManager = null;
    [SerializeField]
    Button _eyebtn;
    [SerializeField, Header("�摜�I�u�W�F�N�g")] Sprite[] sprites;
    public int movephase = 0;
    public SanCount sc;
    private SpriteRenderer _sprite;
    private List<string> _coroutineTable = new List<string>() { "case1", "case2", "case3", "case4", "case5", "case6", "case7" };
    void Start()
    {
        _sprite = gameObject.GetComponent<SpriteRenderer>();
        _eyebtnManager.Setup();
    }
    public void moveclick()
    {
        if (movephase >= sprites.Length)
        {
            movephase = 0;
        }

        Transform camera = Camera.main.transform;
        var pos = camera.transform.position;
        Sequence quence = DOTween.Sequence();
        quence.Append(transform.DOBlendableScaleBy(Vector3.one * 1.0F, 1));
        quence.Insert(0, camera.DOMove(pos + new Vector3(-2, 0, 0), 0.5F));
        quence.Insert(0, camera.DOMove(pos + new Vector3(0, 2, 0), 0.25F));
        quence.Insert(0.25F, camera.DOMove(pos + new Vector3(-2, 0, 0), 0.25F));

        quence.Insert(0.5F, camera.DOMove(pos - new Vector3(0, 0, 0), 0.5F));
        quence.Insert(0.5F, camera.DOMove(pos + new Vector3(1F, 2, 0), 0.25F));
        quence.Insert(0.75F, camera.DOMove(pos - new Vector3(-2, 0, 0), 0.25F));

        quence.OnComplete(() =>
        {
            camera.position = pos;
            gameObject.transform.localScale = Vector3.one;
            _sprite.sprite = sprites[movephase];
            movephase++;
            if (1 <= movephase || movephase <= 7)
                StartCoroutine(_coroutineTable[movephase - 1]);
            else
                _movebtn.interactable = true;
            if (_eyebtnManager.IsCloseEye && !_eyebtnManager.IsClickOnce)
            {
                _sprite.color = Color.white;
                _eyebtnManager.SetClickOnce();
            }
        });
        //����
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        if (_eyebtnManager.IsCloseEye && !_eyebtnManager.IsClickOnce)
        {
            _sprite.color = Color.black;
        }
        
    }
   
    IEnumerator case1()
    {
        //�L�̕\�� �� �t�F�[�h�A�E�g
        _cat.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.cats);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.02f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            _cat.SetActive(false);
            
        }
        //1.5�b��
        yield return new WaitForSeconds(1.5f);
        //�{�^���\��
        _movebtn.interactable = true;
        //�L�̔�\��
        _cat.SetActive(false);//(�����Ă���)
    }
    IEnumerator case2()
    {
        //���ڂɕs�R��
        _farSp.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.farSP);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.03f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            //���ڂɕs�R��
            _farSp.SetActive(false);
            
        }
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        //���ڂɕs�R�҂��\��
        _farSp.SetActive(false);//(�����Ă���)
    }
    IEnumerator case3()
    {
        //�΂ߐ^���ɑ傫�߂ɕs�R��
        _Sp.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.farkunekune);
            SoundManager.Instance.Play_SE(0, 3);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.04f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            _Sp.SetActive(false);
           
            SoundManager.Instance.Play_SE(0, 3);
        }
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        //�΂ߐ^���ɑ傫�߂ɕs�R��
        _Sp.SetActive(false);//(�����Ă���)
    }
    IEnumerator case4()
    {
        //���߂ɂ��˂���(�ڂ���)
        _farkunekune.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.farkunekune);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.03f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            //���߂ɂ��˂���(�ڂ���)
            _farkunekune.SetActive(false);
           
        }
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        SoundManager.Instance.Play_SE(0, 7);
        panel.SetActive(true);
        //panelSE

        //�{�^���\��
        _movebtn.interactable = true;
        
        //���߂ɂ��˂���(�ڂ���)���\��
        _farkunekune.SetActive(false);//(�����Ă���)

    }
    IEnumerator case5()
    {
        //���ڂɈ�u���˂��ˁ���u�ŏ�����
        _kunekune.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.kunekune);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.05f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            //���ڂɈ�u���˂��ˁ���u�ŏ�����
            _kunekune.SetActive(false);
            
        }
        //0.5�b��
        yield return new WaitForSeconds(0.5f);
        //���˂��˂��\��
        _kunekune.SetActive(false);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        //�s�R�ȉ�������B(SE)
        SoundManager.Instance.Play_SE(0, 6);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.UmaSE);
            SoundManager.Instance.Play_SE(0, 6);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            SoundManager.Instance.Play_SE(0, 6);
        }
        
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        _eyebtn.interactable = false;
    }
    IEnumerator case7()
    {
        //UMA�o�Ă���
        _uma.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.Uma);
        }
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.1f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //UMA���\��
        _uma.SetActive(false);
        _uma2.SetActive(true);
        //se
        SoundManager.Instance.Play_SE(0, 5);
        //3�b��
        yield return new WaitForSeconds(3.0f);
        //UMA���\��
        _uma2.SetActive(false);
        //����
        _sandstorm.SetActive(true);
        //
        SoundManager.Instance.Play_SE(0, 4);
        //
        endbtn.SetActive(true);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
       
    }
}
