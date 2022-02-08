using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class MoveBtnDay4 : MonoBehaviour
{
    [SerializeField]
    GameObject _panal;
    [SerializeField]
    GameObject _panal2;
    [SerializeField]
    GameObject movebutton;
    [SerializeField]
    GameObject endbtn;
    [SerializeField]
    Button _movebtn;
    [SerializeField, Header("エネミー画像")]
    GameObject _cat;
    [SerializeField]
    GameObject _kunekune;
    [SerializeField]
    GameObject _farkunekune;
    [SerializeField]
    GameObject _ghost;
    [SerializeField]
    GameObject _farghost;
    [SerializeField]
    GameObject _uma;
    [SerializeField]
    GameObject _sandstorm;
    [SerializeField]
    GameObject _san;
    [SerializeField]
    Slider slider;
    [SerializeField]
    private EyebtnManager _eyebtnManager = null;
    [SerializeField]
    Button _eyebtn;
    [SerializeField, Header("画像オブジェクト")] Sprite[] sprites;
    public int movephase = 0;
    public GameObject btn;
    private SpriteRenderer _sprite;
    public SanCount sc;
    private List<string> _coroutineTable = new List<string>() { "case1", "case2", "case3", "case4", "case5", "case6", "case7" };


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
        //ボタン非表示
        btn.SetActive(false);
        //san非表示
        _san.SetActive(false);
        //1秒後
        yield return new WaitForSeconds(1.0f);
        SoundManager.Instance.Play_SE(0, 5);
        //メッセージウィンドウの表示
        _panal.SetActive(true);
        //SE
        _movebtn.interactable = true;
    }
    IEnumerator case2()
    {
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case3()
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
        //猫の表示
        _cat.SetActive(false);
    }
    IEnumerator case4()
    {
        //すごい遠めにくねくね(ぼかし)
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
            //すごい遠めにくねくね(ぼかし)
            _farkunekune.SetActive(false);

            
        }
        //１秒後
        yield return new WaitForSeconds(1.0f);
    
        //遠めにくねくね(ぼかし)を非表示
        _farkunekune.SetActive(false);//(消していい)
        //ボタン表示
        _movebtn.interactable = true;

    }
    IEnumerator case5()
    {
        //近くににくねくね→一瞬で消える
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
        //0,3秒後
        yield return new WaitForSeconds(0.3f);
        //とりあえず非表示
        _kunekune.SetActive(false);//(消していい)
        movebutton.SetActive(false);
        _san.SetActive(false);
        SoundManager.Instance.Play_SE(0, 6);
        _panal2.SetActive(true);
        //ボタン表示
        _movebtn.interactable = true;

    }
    IEnumerator case6()
    {
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        _eyebtn.interactable = false;
    }
    IEnumerator case7()
    {

        //1秒後
        yield return new WaitForSeconds(1.0f);
        Debug.Log("1");

        //遠目に幽霊
        _farghost.SetActive(true);
        Debug.Log("2");
        sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghost);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.1f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        //3秒後
        yield return new WaitForSeconds(3.0f);

        //遠くの幽霊消す
        _farghost.SetActive(false);

        //ドアップで幽霊すぐに砂嵐
        _ghost.SetActive(true);

        //0.3秒後
        yield return new WaitForSeconds(0.3f);
        _san.SetActive(false);
        //ドアップで幽霊すぐに砂嵐
        _sandstorm.SetActive(true);
        endbtn.SetActive(true);
        //すぐに消す
        _ghost.SetActive(false);

        //1秒後
        yield return new WaitForSeconds(1.0f);

        //ボタン表示
        _movebtn.interactable = true;

        //とりあえず非表示

    }
}
