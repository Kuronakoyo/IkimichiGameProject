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
    [SerializeField, Header("�G�l�~�[�摜")]
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
    [SerializeField, Header("�摜�I�u�W�F�N�g")] Sprite[] sprites;
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
                Debug.LogError("MovePhese�̒l��������܂���");
                break;
        }
    }
    IEnumerator case1()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        btn.SetActive(false);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //���b�Z�[�W�E�B���h�E�̕\��
        _panal.SetActive(true);
    }
    IEnumerator case2()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case3()
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
        //�L�̕\��
        _cat.SetActive(false);
    }
    IEnumerator case4()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //���������߂ɂ��˂���(�ڂ���)
        _farkunekune.SetActive(true);
        //�P�b��
        yield return new WaitForSeconds(1.0f);
        //���߂ɂ��˂���(�ڂ���)���\��
        _farkunekune.SetActive(false);//(�����Ă���)
        //�{�^���\��
        _movebtn.interactable = true;

    }
    IEnumerator case5()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�߂��ɂɂ��˂��ˁ���u�ŏ�����
        _kunekune.SetActive(true);
        //0,3�b��
        yield return new WaitForSeconds(0.3f);
        //�Ƃ肠������\��
        _kunekune.SetActive(false);//(�����Ă���)
        //�{�^���\��
        _movebtn.interactable = true;

    }
    IEnumerator case6()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
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
        Debug.Log("1");

        //���ڂɗH��
        _farghost.SetActive(true);
        Debug.Log("2");

        //3�b��
        yield return new WaitForSeconds(3.0f);

        //�����̗H�����
        _farghost.SetActive(false);

        //�h�A�b�v�ŗH�삷���ɍ���
        _ghost.SetActive(true);

        //0.3�b��
        yield return new WaitForSeconds(0.3f);

        //�h�A�b�v�ŗH�삷���ɍ���
        _sandstorm.SetActive(true);

        //�����ɏ���
        _ghost.SetActive(false);

        //1�b��
        yield return new WaitForSeconds(1.0f);

        //�{�^���\��
        _movebtn.interactable = true;

        //�Ƃ肠������\��

    }
}
