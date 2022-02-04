using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField, Header("エネミー画像")]
    GameObject _cat;
    [SerializeField]
    GameObject _suspiciousPerson;
    [SerializeField]
    GameObject hand;
    [SerializeField]
    GameObject panal1;
    [SerializeField]
    GameObject panal2;
    [SerializeField]
    GameObject panal3;
    [SerializeField]
    GameObject san;
    [SerializeField]
    GameObject movebutton;
    [SerializeField]
    GameObject endbtn;
    [SerializeField]
    Button _movebtn;
    [SerializeField]
    private Slider slider;
    public SanCount sc;
    [SerializeField, Header("画像オブジェクト")] Sprite[] sprites;
    public int movephase = 0;
    private SpriteRenderer _sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        _sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

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
        Debug.Log(movephase);

        Phese(movephase);
    }

    /// <summary>
    /// Phese管理の関数
    /// </summary>
    /// <param name="pheseNum">Pheseの値</param>
    void Phese(int pheseNum)
    {
        switch (pheseNum)
        {
            case 0:
                StartCoroutine("Buttons");
                break;
            case 1:
                StartCoroutine("CatView");
                break;
            case 2:
                StartCoroutine("WhileHandCat");
                break;
            case 3:
                StartCoroutine("Spwara");
                break;
            case 4:
                StartCoroutine("SpView");
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
    IEnumerator CatView()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        SoundManager.Instance.Play_SE(0, 0);
        _movebtn.interactable = false;
        yield return new WaitForSeconds(1.0f);
        _cat.SetActive(true);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.cats);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.02f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        _movebtn.interactable = true;
    }
    IEnumerator WhileHandCat()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        _cat.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        //白い手の音
        SoundManager.Instance.Play_SE(0, 4);
        hand.SetActive(true);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.RedHand);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.05f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(1.5f);
        _movebtn.interactable = true;
        Destroy(hand);
        Destroy(_cat);
        
    }
    IEnumerator Spwara()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.spSE);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.01f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        _movebtn.interactable = false;
        SoundManager.Instance.Play_SE(0, 2);
        yield return new WaitForSeconds(2.0f);
        san.SetActive(false);
        movebutton.SetActive(false);
        panal1.SetActive(true);
        _movebtn.interactable = true;
    }
    IEnumerator SpView()
    {
        //足音
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        yield return new WaitForSeconds(1.0f);
        SoundManager.Instance.Play_SE(0, 3);
        _suspiciousPerson.SetActive(true);
        sc.SubSanScore(CommonGameDataModel.SanSubParam.SP);
        for (int i = 0; i <= 80; i++)
        {
            slider.value -= 0.04f / 80;
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(13.0f);
        Destroy(_suspiciousPerson);
        movebutton.SetActive(false);
        san.SetActive(false);
        panal2.SetActive(true);
    }
   
}

