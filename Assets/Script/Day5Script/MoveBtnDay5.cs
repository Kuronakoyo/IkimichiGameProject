using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class MoveBtnDay5 : MonoBehaviour
{
    [SerializeField]
    GameObject endbtn;
    [SerializeField]
    Button _movebtn;

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

    [SerializeField, Header("画像オブジェクト")] Sprite[] sprites;
    public int movephase = 0;
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
                Debug.LogError("MovePheseの値が見つかりません");
                break;
        }
    }
    IEnumerator case1()
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
    IEnumerator case2()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //草木をかき分けるガサガサ音(SE)

        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case3()          /*/ ghostshadow の名前で 幽霊の影 /*/
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //遠くに一瞬幽霊の影がうつる     /*/ 遠くに配置  /*/
        _ghostshadow.SetActive(true);
        //0.3秒後
        yield return new WaitForSeconds(0.5f);
        //幽霊の影を非表示
        _ghostshadow.SetActive(false);
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case4()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //カラスのなく声(SE)
        SoundManager.Instance.Play_SE(0, 5);
        //1秒後
        yield return new WaitForSeconds(1.0f);
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
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //女性の嗤う声が耳元で(SE)

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
        //幽霊が一瞬画面端に現れ、すぐに消える
        _ghost.SetActive(true);
        //0.3秒後
        yield return new WaitForSeconds(0.3f);
        _ghost.SetActive(false);
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case8()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //鳥居なにもなし

        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
    }
    IEnumerator case9()         /*/ ghostback の名前で ghostと同じ素材 /*/
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        //ボタン非表示
        _movebtn.interactable = false;
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //境内　通りゃんせがBGM(SE)
        SoundManager.Instance.Play_SE(0, 6);
      
        //1秒後
        yield return new WaitForSeconds(1.0f);
        //ボタン表示
        _movebtn.interactable = true;
        
    }
    IEnumerator case10()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);

        //ボタン非表示
        _movebtn.interactable = false;

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

    }
}

//背景素材がないので位置、大きさが仮置きです。