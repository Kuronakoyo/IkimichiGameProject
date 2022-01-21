using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MoveBtnDay3 : MonoBehaviour
{
    [SerializeField, Header("�G�l�~�[�摜")]
    //UMA
    GameObject _uma;
    [SerializeField]
    GameObject _uma2;
    //���˂���
    [SerializeField]
    GameObject _kunekune;
    //�������˂���
    [SerializeField]
    GameObject _farkunekune;
    //�s�R��
    [SerializeField]
    GameObject _Sp;
    //�����s�R��
    [SerializeField]
    GameObject _farSp;
    //�L
    [SerializeField]
    GameObject _cat;
    //����
    [SerializeField]
    GameObject _sandstorm;
    //����I���{�^��
    [SerializeField]
    GameObject endbtn;
    //move�{�^��
    [SerializeField]
    Button _movebtn;
    [SerializeField, Header("�摜�I�u�W�F�N�g")] Sprite[] sprites;
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
    IEnumerator case1()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�L�̕\�� �� �t�F�[�h�A�E�g
        _cat.SetActive(true);
        //1.5�b��
        yield return new WaitForSeconds(1.5f);
        //�{�^���\��
        _movebtn.interactable = true;
        //�L�̔�\��
        _cat.SetActive(false);//(�����Ă���)
    }
    IEnumerator case2()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //���ڂɕs�R��
        _farSp.SetActive(true);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        //���ڂɕs�R�҂��\��
        _farSp.SetActive(false);//(�����Ă���)
    }
    IEnumerator case3()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�΂ߐ^���ɑ傫�߂ɕs�R��
        _Sp.SetActive(true);
        SoundManager.Instance.Play_SE(0, 3);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        //�΂ߐ^���ɑ傫�߂ɕs�R��
        _Sp.SetActive(false);//(�����Ă���)
    }
    IEnumerator case4()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //���߂ɂ��˂���(�ڂ���)
        _farkunekune.SetActive(true);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        //���߂ɂ��˂���(�ڂ���)���\��
        _farkunekune.SetActive(false);//(�����Ă���)
    }
    IEnumerator case5()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //���ڂɈ�u���˂��ˁ���u�ŏ�����
        _kunekune.SetActive(true);
        //0.5�b��
        yield return new WaitForSeconds(0.5f);
        //���˂��˂��\��
        _kunekune.SetActive(false);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //�s�R�ȉ�������B(SE)

        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case7()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //UMA�o�Ă���
        _uma.SetActive(true);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //UMA���\��
        _uma.SetActive(false);
        _uma2.SetActive(true);
        //se
        SoundManager.Instance.Play_SE(0, 5);
        //3�b��
        yield return new WaitForSeconds(3.0f);
        //UMA���\��
        _uma2.SetActive(false);
        //����
        _sandstorm.SetActive(true);
        //
        SoundManager.Instance.Play_SE(0, 4);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
       
    }
}
