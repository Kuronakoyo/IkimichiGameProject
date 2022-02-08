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
    GameObject Sanchi;
    [SerializeField]
    private EyebtnManager _eyebtnManager = null;

    public Sprite[] sprites;
    public GameObject cat;
    public GameObject blackcat;
    public GameObject backcat;
    public GameObject sd;
    public Slider slider;
    public int movephase = 0;
    private SpriteRenderer _sprite;
    public SanCount sc;

    private List<string> _coroutineTable = new List<string>() { "CatSound", "LittleCat", "Cat", };

    void Start()
    {
        _sprite = gameObject.GetComponent<SpriteRenderer>();
        _eyebtnManager.Setup();
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
            if (1 <= movephase || movephase <= 3)
                StartCoroutine(_coroutineTable[movephase - 1]);
            else
                bt.interactable = true;
            if (_eyebtnManager.IsCloseEye && !_eyebtnManager.IsClickOnce)
            {
                _sprite.color = Color.white;
                _eyebtnManager.SetClickOnce();
            }
        });

        //足音
        SoundManager.Instance.Play_SE(0, 1);
        bt.interactable = false;
        if (_eyebtnManager.IsCloseEye && !_eyebtnManager.IsClickOnce)
        {
            _sprite.color = Color.black;
        }
    }
    IEnumerator CatSound()
    {
        //猫の鳴き声
        SoundManager.Instance.Play_SE(0, 0);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            sc.SubSanScore(CommonGameDataModel.SanSubParam.Normal);
            SoundManager.Instance.Play_SE(0, 0);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
            
       
        bt.interactable = true;
    }
    IEnumerator LittleCat()
    {
        bool isExit = false;
        //  猫を表示
        cat.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.cats);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.02f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            cat.SetActive(false);
        }
       
        cat.SetActive(false);
        bt.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver",1.0f);
    }
    IEnumerator Cat()
    {
        //黒猫表示
        blackcat.SetActive(true);
        SoundManager.Instance.Play_SE(0, 0);
        //1.5秒後
        yield return new WaitForSeconds(1.5f);
        blackcat.SetActive(false);
        //backcatのSE
        SoundManager.Instance.Play_SE(0, 2);
        backcat.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        backcat.SetActive(false);
        Destroy(bt.gameObject);
        Sanchi.SetActive(false);
        panel.SetActive(true);
        SoundManager.Instance.Play_SE(0, 4);
        bt.interactable = true;
    }

}
