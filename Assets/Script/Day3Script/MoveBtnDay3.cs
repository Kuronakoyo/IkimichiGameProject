using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MoveBtnDay3 : MonoBehaviour
{
    
    [SerializeField, Header("エネミー画像")]
    //UMA
    GameObject _uma;
    [SerializeField]
    GameObject _uma2;
    //くねくね
    [SerializeField]
    GameObject _kunekune;
    //遠いくねくね
    [SerializeField]
    GameObject _farkunekune;
    //不審者
    [SerializeField]
    GameObject _Sp;
    //遠い不審者
    [SerializeField]
    GameObject _farSp;
    //猫
    [SerializeField]
    GameObject _cat;
    //砂嵐
    [SerializeField]
    GameObject _sandstorm;
    //動画終了ボタン
    [SerializeField]
    GameObject endbtn;
    //moveボタン
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
    [SerializeField, Header("画像オブジェクト")] Sprite[] sprites;
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
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        if (_eyebtnManager.IsCloseEye && !_eyebtnManager.IsClickOnce)
        {
            _sprite.color = Color.black;
        }
        
    }
   
    IEnumerator case1()
    {
        //猫の表示 → フェードアウト
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
        //1.5秒後
        yield return new WaitForSeconds(1.5f);
        //ボタン表示
        _movebtn.interactable = true;
        //猫の非表示
        _cat.SetActive(false);//(消していい)
    }
    IEnumerator case2()
    {
        //遠目に不審者
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
            //遠目に不審者
            _farSp.SetActive(false);
            
        }
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        //遠目に不審者を非表示
        _farSp.SetActive(false);//(消していい)
    }
    IEnumerator case3()
    {
        //斜め真横に大きめに不審者
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
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        //斜め真横に大きめに不審者
        _Sp.SetActive(false);//(消していい)
    }
    IEnumerator case4()
    {
        //遠めにくねくね(ぼかし)
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
            //遠めにくねくね(ぼかし)
            _farkunekune.SetActive(false);
           
        }
        //１秒後
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        SoundManager.Instance.Play_SE(0, 7);
        panel.SetActive(true);
        //panelSE

        //ボタン表示
        _movebtn.interactable = true;
        
        //遠めにくねくね(ぼかし)を非表示
        _farkunekune.SetActive(false);//(消していい)

    }
    IEnumerator case5()
    {
        //遠目に一瞬くねくね→一瞬で消える
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
            //遠目に一瞬くねくね→一瞬で消える
            _kunekune.SetActive(false);
            
        }
        //0.5秒後
        yield return new WaitForSeconds(0.5f);
        //くねくねを非表示
        _kunekune.SetActive(false);
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        //不審な音を入れる。(SE)
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
        
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        _eyebtn.interactable = false;
    }
    IEnumerator case7()
    {
        //UMA出てきて
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
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //UMAを非表示
        _uma.SetActive(false);
        _uma2.SetActive(true);
        //se
        SoundManager.Instance.Play_SE(0, 5);
        //3秒後
        yield return new WaitForSeconds(3.0f);
        //UMAを非表示
        _uma2.SetActive(false);
        //砂嵐
        _sandstorm.SetActive(true);
        //
        SoundManager.Instance.Play_SE(0, 4);
        //
        endbtn.SetActive(true);
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
       
    }
}
