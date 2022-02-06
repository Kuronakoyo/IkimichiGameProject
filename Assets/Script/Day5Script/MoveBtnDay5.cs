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

    [SerializeField, Header("ƒGƒlƒ~[‰æ‘œ")]
 
    //—H—ì
    GameObject _ghost;

    //—H—ì‚ÌU‚è•Ô‚è
    [SerializeField]
    GameObject _ghostlookback;

    //—H—ì‚Ì³–Ê
    [SerializeField]
    GameObject _ghostfront;

    //—H—ì‚ÌÎŠç
    [SerializeField]
    GameObject _ghostsmile;

    //—H—ì‚Ì•–Ú‚ÌÎŠç
    [SerializeField]
    GameObject _ghostbracksmile;

    //—H—ì‚Ì³–Ê‚Ì‚Ì‰e
    [SerializeField]
    GameObject _ghostfrontshadow;

    //—H—ì‚Ì‰e
    [SerializeField]
    GameObject _ghostshadow;

    //—H—ì‚Ì¶ñ
    [SerializeField]
    GameObject _ghosthead;

    //BG
    [SerializeField]
    GameObject _bg;

    [SerializeField, Header("‰æ‘œƒIƒuƒWƒFƒNƒg")] Sprite[] sprites;
    public int movephase = 0;
    public SanCount sc;
    private SpriteRenderer _sprite;
    // Start is called before the first frame update
    void Start()
    {
        _sprite = gameObject.GetComponent<SpriteRenderer>();
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
        });
        Debug.Log(movephase);

        Phese(movephase);

    }
    void Phese(int pheseNum)
    {
        switch (pheseNum)
        {
            case 0:
                StartCoroutine("case1");
                break;
            case 1:
                StartCoroutine("case2");
                break;
            case 2:
                StartCoroutine("case3");
                break;
            case 3:
                StartCoroutine("case4");
                break;
            case 4:
                StartCoroutine("case5");
                break;
            case 5:
                StartCoroutine("case6");
                break;
            case 6:
                StartCoroutine("case7");
                break;
            case 7:
                StartCoroutine("case8");
                break;
            case 8:
                StartCoroutine("case9");
                break;
            case 9:
                StartCoroutine("case10");
                break;
            default:
                Debug.LogError("MovePhese‚Ì’l‚ªŒ©‚Â‚©‚è‚Ü‚¹‚ñ");
                break;
        }
    }
    IEnumerator case1()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
    IEnumerator case2()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //‘–Ø‚ğ‚©‚«•ª‚¯‚éƒKƒTƒKƒT‰¹(SE)
        SoundManager.Instance.Play_SE(0, 8);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.kusaSE);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.01f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
        IEnumerator case3()          /*/ ghostshadow ‚Ì–¼‘O‚Å —H—ì‚Ì‰e /*/
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //‰“‚­‚Éˆêu—H—ì‚Ì‰e‚ª‚¤‚Â‚é     /*/ ‰“‚­‚É”z’u  /*/
        _ghostshadow.SetActive(true);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghostshadow);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.03f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        //0.3•bŒã
        yield return new WaitForSeconds(0.5f);
        //—H—ì‚Ì‰e‚ğ”ñ•\¦
        _ghostshadow.SetActive(false);
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
    IEnumerator case4()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //ƒJƒ‰ƒX‚Ì‚È‚­º(SE)
        SoundManager.Instance.Play_SE(0, 5);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.karasuSE);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.01f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
    IEnumerator case5()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //—«‚Ìšo‚¤º‚ª¨Œ³‚Å(SE)
        SoundManager.Instance.Play_SE(0, 7);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.GrilSE);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.01f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
    IEnumerator case7()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //—H—ì‚ªˆêu‰æ–Ê’[‚ÉŒ»‚êA‚·‚®‚ÉÁ‚¦‚é
        _ghost.SetActive(true);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghostbyo);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.01f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        //0.3•bŒã
        yield return new WaitForSeconds(0.3f);
        _ghost.SetActive(false);
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
    IEnumerator case8()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //’¹‹‚È‚É‚à‚È‚µ

        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
    }
    IEnumerator case9()         /*/ ghostback ‚Ì–¼‘O‚Å ghost‚Æ“¯‚¶‘fŞ /*/
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);
        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //‹«“à@’Ê‚è‚á‚ñ‚¹‚ªBGM(SE)
        SoundManager.Instance.Play_SE(0, 6);
      
        //1•bŒã
        yield return new WaitForSeconds(1.0f);
        //ƒ{ƒ^ƒ“•\¦
        _movebtn.interactable = true;
        
    }
    IEnumerator case10()
    {
        //‘«‰¹
        SoundManager.Instance.Play_SE(0, 1);

        //ƒ{ƒ^ƒ“”ñ•\¦
        _movebtn.interactable = false;

        //1•bŒã
        yield return new WaitForSeconds(1.0f);

        // —H—ì³–Ê‚Ì‰e
        _ghostfrontshadow.SetActive(true);

        //1•bŒã
        yield return new WaitForSeconds(1.0f);

        //—H—ìU‚è•Ô‚é
        _ghostlookback.SetActive(true);

        // —H—ì³–Ê‚Ì‰e”ñ•\¦
        _ghostfrontshadow.SetActive(false);

        //1.5•bŒã
        yield return new WaitForSeconds(1.5f);

         //—H—ì³–Ê‚ğ•\¦
        _ghostfront.SetActive(true);

        //—H—ìU‚è•Ô‚è‚ğÁ‚·
        _ghostlookback.SetActive(false);

        //3•bŒã
        yield return new WaitForSeconds(3.0f);

        //—H—ìÎŠç‚ğ•\¦
        _ghostsmile.SetActive(true);

        //—H—ì³–Ê‚ğ”ñ•\¦
        _ghostfront.SetActive(false);

        //1.5•bŒã
        yield return new WaitForSeconds(1.5f);

        //—H—ì‚Å•–ÚÎŠç‚ğ•\¦
        _ghostbracksmile.SetActive(true);

        //—H—ìÎŠç‚ğ”ñ•\¦
        _ghostsmile.SetActive(false);

        //4•bŒã
        yield return new WaitForSeconds(4.0f);

        //BG‚ğ^‚Á•‚É(UIíœ‚ª‚í‚©‚ç‚È‚©‚Á‚½‚½‚ß)
        _bg.SetActive(true);

        //—H—ì‚Å•–ÚÎŠç‚ğ”ñ•\¦
        _ghostbracksmile.SetActive(false);

        //10•bŒã
        yield return new WaitForSeconds(10f);

        //—H—ì‚Ì¶ñ•\¦
        _ghosthead.SetActive(true);
        //10•bŒã
        yield return new WaitForSeconds(3f);

        //—H—ì‚Ì¶ñ•\¦
        _ghosthead.SetActive(false);
        //ƒ{ƒ^ƒ“•\¦
        endbtn.SetActive(true);
    }
}

//”wŒi‘fŞ‚ª‚È‚¢‚Ì‚ÅˆÊ’uA‘å‚«‚³‚ª‰¼’u‚«‚Å‚·B