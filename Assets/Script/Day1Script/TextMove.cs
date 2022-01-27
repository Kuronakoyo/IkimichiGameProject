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
        //‘«‰¹
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
        //”LSE
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
        //•”L‚ð•\Ž¦‚³‚¹‚é
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
        //•”L‚ð•\Ž¦‚³‚¹‚é
        blackcat.SetActive(true);
        SoundManager.Instance.Play_SE(0, 0);
        //ˆê•bŒã
        yield return new WaitForSeconds(1.5f);
        blackcat.SetActive(false);
        //”LSE
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
    //ƒtƒF[ƒY‚P‚Ìê‡
    void phese1()
    {
        StartCoroutine("CatSound");
    }
    //ƒtƒF[ƒY‚Q‚Ìê‡
    void phese2()
    {
        StartCoroutine("LittleCat");

    }
    //ƒtƒF[ƒY‚R‚Ìê‡
    void phese3()
    {
        //‚à‚µisback‚ªƒIƒ“‚É‚È‚Á‚½‚ç
        if (isback != true)
        {
            //”L‚ð”ñ•\Ž¦
            cat.SetActive(false);
            StartCoroutine("Cat");
        }
        //‚Ù‚©
        else
        {
            //”L”ñ•\Ž¦‚³‚¹‚é
            cat.SetActive(false);
        }
    }
    //ƒtƒF[ƒY‚S‚Ìê‡
    void phese4()
    {
        //‚à‚µ•”L‚ª•\Ž¦‚³‚¹‚½ê‡
        if (blackcat.activeInHierarchy)
        {
            //ƒXƒNƒ[ƒ‹ƒo[‚ðŒ¸‚ç‚·
           // StartCoroutine(Bar());
        }
        //•”L‚ð”ñ•\Ž¦‚³‚¹‚é
        blackcat.SetActive(false);
        //
        
    }
    //ƒtƒF[ƒY‚T‚Ìê‡
    void phese5()
    {
        //ƒ{ƒ^ƒ“‚ð”ñ•\Ž¦‚³‚¹‚é
        bt.interactable = false;
        //‚Q•bŒã‚ÉstartƒV[ƒ“‚É‘JˆÚ‚·‚é
        FadeManager.Instance.LoadScene("Start", 2.0f);
        
    }


}
