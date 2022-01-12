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
    [SerializeField, Header("画像オブジェクト")] Sprite[] sprites;
    public int movephase = 0;
    public GameObject btn;
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
        quence.Append(transform.DOBlendableScaleBy(Vector3.one * 1.5F, 1));
        quence.Insert(0, camera.DOMove(pos + new Vector3(-2, 0, 0), 0.5F));
        quence.Insert(0, camera.DOMove(pos + new Vector3(-1F, 2, 0), 0.25F));
        quence.Insert(0.25F, camera.DOMove(pos + new Vector3(-2, 0, 0), 0.25F));

        quence.Insert(0.5F, camera.DOMove(pos - new Vector3(-2, 0, 0), 0.5F));
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
            default:
                Debug.LogError("MovePheseの値が見つかりません");
                break;
        }
    }
    IEnumerator case1()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        btn.SetActive(false);
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //メッセージウィンドウの表示
        _panal.SetActive(true);
    }
    IEnumerator case2()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case3()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //猫の表示
        _cat.SetActive(true);
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        //猫の非表示
        _cat.SetActive(false);//(消していい)
    }
    IEnumerator case4()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //すごい遠めにくねくね(ぼかし)
        _kunekune.SetActive(true);
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //遠めにくねくね(ぼかし)を非表示
        _kunekune.SetActive(false);//(消していい)
        //ボタン表示
        _movebtn.interactable = true;

    }
    IEnumerator case5()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //近くににくねくね→一瞬で消える
        _farkunekune.SetActive(true);
        //0,3秒後
        yield return new WaitForSeconds(0.3f);
        //とりあえず非表示
        _farkunekune.SetActive(false);//(消していい)
        //ボタン表示
        _movebtn.interactable = true;
      
    }
    IEnumerator case6()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case7()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //遠目に幽霊
        _ghost.SetActive(true);
        //3秒後
        yield return new WaitForSeconds(3.0f);
        //遠くの幽霊消す
        _ghost.SetActive(false);
        //ドアップで幽霊すぐに砂嵐
        _farghost.SetActive(true);
        //0.3秒後
        yield return new WaitForSeconds(0.3f);
        //すぐに消す
        _farghost.SetActive(false);

        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        //とりあえず非表示
        
    }
}
