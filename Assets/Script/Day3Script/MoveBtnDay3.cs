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
    [SerializeField, Header("画像オブジェクト")] Sprite[] sprites;
    public int movephase = 0;
    private SpriteRenderer _sprite;
   
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
            default:
                Debug.LogError("MovePheseの値が見つかりません");
                break;
        }
    }
    IEnumerator Buttons()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        yield return new WaitForSeconds(1.0f);
        _movebtn.interactable = true;
    }
    IEnumerator case1()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //猫の表示 → フェードアウト
        _cat.SetActive(true);
        //1.5秒後
        yield return new WaitForSeconds(1.5f);
        //ボタン表示
        _movebtn.interactable = true;
        //猫の非表示
        _cat.SetActive(false);//(消していい)
    }
    IEnumerator case2()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //遠目に不審者
        _farSp.SetActive(true);
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        //遠目に不審者を非表示
        _farSp.SetActive(false);//(消していい)
    }
    IEnumerator case3()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //斜め真横に大きめに不審者
        _Sp.SetActive(true);
        SoundManager.Instance.Play_SE(0, 3);
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        //斜め真横に大きめに不審者
        _Sp.SetActive(false);//(消していい)
    }
    IEnumerator case4()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //遠めにくねくね(ぼかし)
        _farkunekune.SetActive(true);
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        //遠めにくねくね(ぼかし)を非表示
        _farkunekune.SetActive(false);//(消していい)
    }
    IEnumerator case5()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //遠目に一瞬くねくね→一瞬で消える
        _kunekune.SetActive(true);
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
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //不審な音を入れる。(SE)

        //１秒後
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
        //UMA出てきて
        _uma.SetActive(true);
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
        //１秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
       
    }
}
