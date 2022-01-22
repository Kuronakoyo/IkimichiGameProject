using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField, Header("�G�l�~�[�摜")]
    GameObject _cat;
    [SerializeField]
    GameObject _suspiciousPerson;
    [SerializeField]
    GameObject hand;
    [SerializeField]
    Button _movebtn;
    Enemy _enemy;
    [SerializeField, Header("�摜�I�u�W�F�N�g")] Sprite[] sprites;
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

    /// <summary>
    /// Phese�Ǘ��̊֐�
    /// </summary>
    /// <param name="pheseNum">Phese�̒l</param>
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
                Debug.LogError("MovePhese�̒l��������܂���");
                break;
        }
    }
    IEnumerator Buttons()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        yield return new WaitForSeconds(1.0f);
        _movebtn.interactable = true;
    }
    IEnumerator CatView()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        SoundManager.Instance.Play_SE(0, 0);
        _movebtn.interactable = false;
        yield return new WaitForSeconds(1.0f);
        _cat.SetActive(true);
        _movebtn.interactable = true;
    }
    IEnumerator WhileHandCat()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        _cat.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        _movebtn.interactable = true;
        hand.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Destroy(hand);
        Destroy(_cat);
        
    }
    IEnumerator Spwara()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        yield return new WaitForSeconds(1.0f);
        SoundManager.Instance.Play_SE(0, 2);
        _movebtn.interactable = true;
    }
    IEnumerator SpView()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        yield return new WaitForSeconds(1.0f);
        SoundManager.Instance.Play_SE(0, 3);
        _movebtn.interactable = true;
        _suspiciousPerson.SetActive(true);
    }
}

