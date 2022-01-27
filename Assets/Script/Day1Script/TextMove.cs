using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class TextMove : MonoBehaviour
{
    [SerializeField]
    private Button bt;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    Button Eyebtn;
    public Sprite[] sprites;
    public GameObject cat;
    public GameObject blackcat;
    public GameObject backcat;
    public GameObject sd;
    public GameObject Sanchi;
    public Slider slider;
    public int movephase = 0;
    private SpriteRenderer _sprite;
    private bool isback = false;
    public SanCount sc;
    void Start()
    {
        _sprite = gameObject.GetComponent<SpriteRenderer>();
    }
   
    public void OnCilick()
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
        
        switch (movephase)
        {
            default:
                phese0();
                break;
            case 1:
                phese1();
                break;
            case 2:
                phese2();
                break;
            case 3:
                phese3();
                break;
            case 4:
                phese4();
                break;
            case 5:
                phese5();
                break;
        }
    }
    IEnumerator Buttons()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        bt.interactable = false;
        yield return new WaitForSeconds(1.0f);
        if (Eyebtn.interactable == false)
        {
            _sprite.color = new Color32(255, 255, 255, 255);
        }
        bt.interactable = true;
    }
    IEnumerator CatSound()
    {
        SoundManager.Instance.Play_SE(0, 1);
        bt.interactable = false;
        yield return new WaitForSeconds(1.0f);
        if (Eyebtn.interactable == false)
        {
            _sprite.color = new Color32(255, 255, 255, 255);
        }
        bt.interactable = true;
        //猫SE
        SoundManager.Instance.Play_SE(0,0);
        sc.SE();
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.01f / 80;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator LittleCat()
    {
        SoundManager.Instance.Play_SE(0, 1);
        bt.interactable = false;
        yield return new WaitForSeconds(1.0f);
        if (Eyebtn.interactable == false)
        {
            _sprite.color = new Color32(255, 255, 255, 255);
        }
        //黒猫を表示させる
        cat.SetActive(true);
        sc.cats();
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.02f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        bt.interactable = true;
    }
    IEnumerator Cat()
    {
        SoundManager.Instance.Play_SE(0, 1);
        bt.interactable = false;
        yield return new WaitForSeconds(1.0f);
        //黒猫を表示させる
        blackcat.SetActive(true);
        SoundManager.Instance.Play_SE(0, 0);
        //一秒後
        yield return new WaitForSeconds(1.5f);
        blackcat.SetActive(false);
        //猫SE
        SoundManager.Instance.Play_SE(0, 2);
        backcat.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        backcat.SetActive(false);
        Destroy(bt.gameObject);
        Sanchi.SetActive(false);
        panel.SetActive(true);
    }
    void phese0()
    {
        
        StartCoroutine("Buttons");
        
    }
    //フェーズ１の場合
    void phese1()
    {
        StartCoroutine("CatSound");
    }
    //フェーズ２の場合
    void phese2()
    {
        StartCoroutine("LittleCat");

    }
    //フェーズ３の場合
    void phese3()
    {
        //もしisbackがオンになったら
        if (isback != true)
        {
            //猫を非表示
            cat.SetActive(false);
            StartCoroutine("Cat");
        }
        //ほか
        else
        {
            //猫非表示させる
            cat.SetActive(false);
        }
    }
    //フェーズ４の場合
    void phese4()
    {
        //もし黒猫が表示させた場合
        if (blackcat.activeInHierarchy)
        {
            //スクロールバーを減らす
           // StartCoroutine(Bar());
        }
        //黒猫を非表示させる
        blackcat.SetActive(false);
        //
        
    }
    //フェーズ５の場合
    void phese5()
    {
        //ボタンを非表示させる
        bt.interactable = false;
        //２秒後にstartシーンに遷移する
        FadeManager.Instance.LoadScene("Start", 2.0f);
        
    }


}
