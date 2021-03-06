using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class MoveBtnDay5 : MonoBehaviour
{
    [SerializeField]
    GameObject movebutton;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject san;
    [SerializeField]
    GameObject endbtn;
    [SerializeField]
    Button _movebtn;
    [SerializeField]
    Slider slider;

    [SerializeField, Header("エネミー画像")]
 
    //幽霊
    GameObject _ghost;

    //幽霊の振り返り
    [SerializeField]
    GameObject _ghostlookback;

    //幽霊の正面
    [SerializeField]
    GameObject _ghostfront;

    //幽霊の笑顔
    [SerializeField]
    GameObject _ghostsmile;

    //幽霊の黒目の笑顔
    [SerializeField]
    GameObject _ghostbracksmile;

    //幽霊の正面の時の影
    [SerializeField]
    GameObject _ghostfrontshadow;

    //幽霊の影
    [SerializeField]
    GameObject _ghostshadow;

    //幽霊の生首
    [SerializeField]
    GameObject _ghosthead;

    //BG
    [SerializeField]
    GameObject _bg;

    [SerializeField]
    private EyebtnManager _eyebtnManager = null;

    [SerializeField]
    Button _eyebtn;
    [SerializeField, Header("画像オブジェクト")] Sprite[] sprites;
    public int movephase = 0;
    public SanCount sc;
    private SpriteRenderer _sprite;
    private List<string> _coroutineTable = new List<string>() { "case1", "case2", "case3", "case4", "case5", "case6", "case7", "case8", "case9", "case10" };
    // Start is called before the first frame update
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
            if (1 <= movephase || movephase <= 10)
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
        //1秒後
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //SE

        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case2()
    {
        bool isExit = false;
        //草木をかき分けるガサガサ音(SE)
        SoundManager.Instance.Play_SE(0, 8);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.kusaSE);
            //草木をかき分けるガサガサ音(SE)
            SoundManager.Instance.Play_SE(0, 8);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            //草木をかき分けるガサガサ音(SE)
            SoundManager.Instance.Play_SE(0, 8);
           
        }
       
        //1秒後
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //SE

        //ボタン表示
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
        IEnumerator case3()          /*/ ghostshadow の名前で 幽霊の影 /*/
    {
        bool isExit = false;
        //遠くに一瞬幽霊の影がうつる     /*/ 遠くに配置  /*/
        _ghostshadow.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit =  sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghostshadow);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.03f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            //遠くに一瞬幽霊の影がうつる     /*/ 遠くに配置  /*/
            _ghostshadow.SetActive(false);
           
        }
        //0.3秒後
        yield return new WaitForSeconds(0.5f);
        //幽霊の影を非表示
        _ghostshadow.SetActive(false);
        //1秒後
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //ボタン表示
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case4()
    {
        bool isExit = false;
        //カラスのなく声(SE)
        SoundManager.Instance.Play_SE(0, 5);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit =  sc.SubSanScore(CommonGameDataModel.SanSubParam.karasuSE);
            SoundManager.Instance.Play_SE(0, 5);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            SoundManager.Instance.Play_SE(0, 5);
          
        }
        //1秒後
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //ボタン表示
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case5()
    {
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        bool isExit = false;
        //女性の嗤う声が耳元で(SE)
        SoundManager.Instance.Play_SE(0, 6);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.GrilSE);
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
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case7()
    {
        bool isExit = false;
        //幽霊が一瞬画面端に現れ、すぐに消える
        _ghost.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghostbyo);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.02f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            _ghost.SetActive(false);
           
        }
        //0.3秒後
        yield return new WaitForSeconds(0.3f);
        _ghost.SetActive(false);
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case8()
    {
        //鳥居なにもなし

        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case9()         /*/ ghostback の名前で ghostと同じ素材 /*/
    {
        bool isExit = false;
        //境内　通りゃんせがBGM(SE)
        SoundManager.Instance.Play_SE(0, 7);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.Normal);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        _eyebtn.interactable = false;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case10()
    {
        bool isExit = false;
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghost);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.1f / 80;
                yield return new WaitForSeconds(0.01f);
            }
            if (isExit)
                FadeManager.Instance.LoadScene("GameOver", 1.0f);
            //1秒後
            yield return new WaitForSeconds(1.0f);

            // 幽霊正面の影
            _ghostfrontshadow.SetActive(true);

            //1秒後
            yield return new WaitForSeconds(1.0f);

            //幽霊振り返る
            _ghostlookback.SetActive(true);

            // 幽霊正面の影非表示
            _ghostfrontshadow.SetActive(false);

            //1.5秒後
            yield return new WaitForSeconds(1.5f);

            //幽霊正面を表示
            _ghostfront.SetActive(true);

            //幽霊振り返りを消す
            _ghostlookback.SetActive(false);

            //3秒後
            yield return new WaitForSeconds(3.0f);

            //幽霊笑顔を表示
            _ghostsmile.SetActive(true);

            //幽霊正面を非表示
            _ghostfront.SetActive(false);

            //1.5秒後
            yield return new WaitForSeconds(1.5f);

            //幽霊で黒目笑顔を表示
            _ghostbracksmile.SetActive(true);

            //幽霊笑顔を非表示
            _ghostsmile.SetActive(false);

            //4秒後
            yield return new WaitForSeconds(4.0f);

            //BGを真っ黒に(UI削除がわからなかったため)
            _bg.SetActive(true);

            //幽霊で黒目笑顔を非表示
            _ghostbracksmile.SetActive(false);

            //10秒後
            yield return new WaitForSeconds(10f);

            //幽霊の生首表示
            _ghosthead.SetActive(true);
            //10秒後
            yield return new WaitForSeconds(3f);

            //幽霊の生首表示
            _ghosthead.SetActive(false);
            //ボタン表示
            endbtn.SetActive(true);
        }
        else
        {
            
        }
       
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
        
    }
}

//背景素材がないので位置、大きさが仮置きです。