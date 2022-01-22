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

    [SerializeField, Header("�G�l�~�[�摜")]
 
    //�H��
    GameObject _ghost;

    //�H��̐���
    [SerializeField]
    GameObject _ghostfront;

    //�H��̌��p
    [SerializeField]
    GameObject _ghostback;

    //�H��̉e
    [SerializeField]
    GameObject _ghostshadow;

    [SerializeField, Header("�摜�I�u�W�F�N�g")] Sprite[] sprites;
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
                Debug.LogError("MovePhese�̒l��������܂���");
                break;
        }
    }
    IEnumerator case1()
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
    IEnumerator case2()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //���؂�����������K�T�K�T��(SE)

        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case3()          /*/ ghostshadow �̖��O�� �H��̉e /*/
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�����Ɉ�u�H��̉e������     /*/ �����ɔz�u  /*/
        _ghostshadow.SetActive(true);
        //0.3�b��
        yield return new WaitForSeconds(0.3f);
        //�H��̉e���\��
        _ghostshadow.SetActive(false);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case4()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //�J���X�̂Ȃ���(SE)
        SoundManager.Instance.Play_SE(0, 5);
        //1�b��
        yield return new WaitForSeconds(1.0f);
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
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //�����̚o������������(SE)

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
        //�H�삪��u��ʒ[�Ɍ���A�����ɏ�����
        _ghost.SetActive(true);
        //0.3�b��
        yield return new WaitForSeconds(0.3f);
        _ghost.SetActive(false);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case8()
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //�����Ȃɂ��Ȃ�?

        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case9()         /*/ ghostback �̖��O�� ghost�Ɠ����f�� /*/
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�����@�ʂ��񂹂�BGM(SE)
        SoundManager.Instance.Play_SE(0, 6);
        //�H����p��������
        _ghostback.SetActive(true);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        //�H����p���\��
        _ghostback.SetActive(false);
    }
    IEnumerator case10()         /*/ ghostfrot �̖��O�� �O�����̗H�� /*/
    {
        //����
        SoundManager.Instance.Play_SE(0, 1);
        //�{�^����\��
        _movebtn.interactable = false;
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�H��\��                              
        _ghostfront.SetActive(true);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        //�H���\��
        _ghostfront.SetActive(true);
    }
}

//�w�i�f�ނ��Ȃ��̂ňʒu�A�傫�������u���ł��B