using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class MoveBtnDay5 : MonoBehaviour
{
    [SerializeField]
    GameObject movebutton;
    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject san;
    [SerializeField]
    GameObject endbtn;
    [SerializeField]
    Button _movebtn;
    [SerializeField]
    Slider slider;

    [SerializeField, Header("�G�l�~�[�摜")]
 
    //�H��
    GameObject _ghost;

    //�H��̐U��Ԃ�
    [SerializeField]
    GameObject _ghostlookback;

    //�H��̐���
    [SerializeField]
    GameObject _ghostfront;

    //�H��̏Ί�
    [SerializeField]
    GameObject _ghostsmile;

    //�H��̍��ڂ̏Ί�
    [SerializeField]
    GameObject _ghostbracksmile;

    //�H��̐��ʂ̎��̉e
    [SerializeField]
    GameObject _ghostfrontshadow;

    //�H��̉e
    [SerializeField]
    GameObject _ghostshadow;

    //�H��̐���
    [SerializeField]
    GameObject _ghosthead;

    //BG
    [SerializeField]
    GameObject _bg;

    [SerializeField]
    private EyebtnManager _eyebtnManager = null;

    [SerializeField]
    Button _eyebtn;
    [SerializeField, Header("�摜�I�u�W�F�N�g")] Sprite[] sprites;
    public int movephase = 0;
    public SanCount sc;
    private SpriteRenderer _sprite;
    private List<string> _coroutineTable = new List<string>() { "case1", "case2", "case3", "case4", "case5", "case6", "case7", "case8", "case9", "case10" };
    // Start is called before the first frame update
    void Start()
    {
        _sprite = gameObject.GetComponent<SpriteRenderer>();
        _eyebtnManager.Setup();
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
            if (1 <= movephase || movephase <= 10)
                StartCoroutine(_coroutineTable[movephase - 1]);
            else
                _movebtn.interactable = true;
            if (_eyebtnManager.IsCloseEye && !_eyebtnManager.IsClickOnce)
            {
                _sprite.color = Color.white;
                _eyebtnManager.SetClickOnce();
            }
        });
        //����
        SoundManager.Instance.Play_SE(0, 1);
        _movebtn.interactable = false;
        if (_eyebtnManager.IsCloseEye && !_eyebtnManager.IsClickOnce)
        {
            _sprite.color = Color.black;
        }

    }
    IEnumerator case1()
    {
        //1�b��
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //SE

        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case2()
    {
        bool isExit = false;
        //���؂�����������K�T�K�T��(SE)
        SoundManager.Instance.Play_SE(0, 8);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.kusaSE);
            //���؂�����������K�T�K�T��(SE)
            SoundManager.Instance.Play_SE(0, 8);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            //���؂�����������K�T�K�T��(SE)
            SoundManager.Instance.Play_SE(0, 8);
           
        }
       
        //1�b��
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //SE

        //�{�^���\��
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
        IEnumerator case3()          /*/ ghostshadow �̖��O�� �H��̉e /*/
    {
        bool isExit = false;
        //�����Ɉ�u�H��̉e������     /*/ �����ɔz�u  /*/
        _ghostshadow.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit =  sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghostshadow);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.03f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            //�����Ɉ�u�H��̉e������     /*/ �����ɔz�u  /*/
            _ghostshadow.SetActive(false);
           
        }
        //0.3�b��
        yield return new WaitForSeconds(0.5f);
        //�H��̉e���\��
        _ghostshadow.SetActive(false);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //�{�^���\��
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case4()
    {
        bool isExit = false;
        //�J���X�̂Ȃ���(SE)
        SoundManager.Instance.Play_SE(0, 5);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit =  sc.SubSanScore(CommonGameDataModel.SanSubParam.karasuSE);
            SoundManager.Instance.Play_SE(0, 5);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            SoundManager.Instance.Play_SE(0, 5);
          
        }
        //1�b��
        yield return new WaitForSeconds(1.0f);
        movebutton.SetActive(false);
        san.SetActive(false);
        panel.SetActive(true);
        //�{�^���\��
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case5()
    {
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case6()
    {
        bool isExit = false;
        //�����̚o������������(SE)
        SoundManager.Instance.Play_SE(0, 6);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.GrilSE);
            SoundManager.Instance.Play_SE(0, 6);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            
            SoundManager.Instance.Play_SE(0, 6);
        }
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case7()
    {
        bool isExit = false;
        //�H�삪��u��ʒ[�Ɍ���A�����ɏ�����
        _ghost.SetActive(true);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghostbyo);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.02f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            _ghost.SetActive(false);
           
        }
        //0.3�b��
        yield return new WaitForSeconds(0.3f);
        _ghost.SetActive(false);
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case8()
    {
        //�����Ȃɂ��Ȃ�

        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
    }
    IEnumerator case9()         /*/ ghostback �̖��O�� ghost�Ɠ����f�� /*/
    {
        bool isExit = false;
        //�����@�ʂ��񂹂�BGM(SE)
        SoundManager.Instance.Play_SE(0, 7);
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.Normal);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.01f / 80;
                yield return new WaitForSeconds(0.01f);
            }
        }
        //1�b��
        yield return new WaitForSeconds(1.0f);
        //�{�^���\��
        _movebtn.interactable = true;
        _eyebtn.interactable = false;
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
    }
    IEnumerator case10()
    {
        bool isExit = false;
        if (!_eyebtnManager.IsCloseEye || _eyebtnManager.IsClickOnce)
        {
            isExit = sc.SubSanScore(CommonGameDataModel.SanSubParam.Ghost);
            for (int i = 0; i <= 80; i++)
            {
                slider.value -= 0.1f / 80;
                yield return new WaitForSeconds(0.01f);
            }
            if (isExit)
                FadeManager.Instance.LoadScene("GameOver", 1.0f);
            //1�b��
            yield return new WaitForSeconds(1.0f);

            // �H�쐳�ʂ̉e
            _ghostfrontshadow.SetActive(true);

            //1�b��
            yield return new WaitForSeconds(1.0f);

            //�H��U��Ԃ�
            _ghostlookback.SetActive(true);

            // �H�쐳�ʂ̉e��\��
            _ghostfrontshadow.SetActive(false);

            //1.5�b��
            yield return new WaitForSeconds(1.5f);

            //�H�쐳�ʂ�\��
            _ghostfront.SetActive(true);

            //�H��U��Ԃ������
            _ghostlookback.SetActive(false);

            //3�b��
            yield return new WaitForSeconds(3.0f);

            //�H��Ί��\��
            _ghostsmile.SetActive(true);

            //�H�쐳�ʂ��\��
            _ghostfront.SetActive(false);

            //1.5�b��
            yield return new WaitForSeconds(1.5f);

            //�H��ō��ڏΊ��\��
            _ghostbracksmile.SetActive(true);

            //�H��Ί���\��
            _ghostsmile.SetActive(false);

            //4�b��
            yield return new WaitForSeconds(4.0f);

            //BG��^������(UI�폜���킩��Ȃ���������)
            _bg.SetActive(true);

            //�H��ō��ڏΊ���\��
            _ghostbracksmile.SetActive(false);

            //10�b��
            yield return new WaitForSeconds(10f);

            //�H��̐���\��
            _ghosthead.SetActive(true);
            //10�b��
            yield return new WaitForSeconds(3f);

            //�H��̐���\��
            _ghosthead.SetActive(false);
            //�{�^���\��
            endbtn.SetActive(true);
        }
        else
        {
            
        }
       
        if (isExit)
            FadeManager.Instance.LoadScene("GameOver", 1.0f);
        
    }
}

//�w�i�f�ނ��Ȃ��̂ňʒu�A�傫�������u���ł��B