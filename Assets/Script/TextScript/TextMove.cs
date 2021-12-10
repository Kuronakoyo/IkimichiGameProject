using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class TextMove : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> background;
    [SerializeField]
    private GameObject image;
    [SerializeField]
    private Button bt;
    [SerializeField]
    GameObject backbt;
    [SerializeField]
    GameObject panel;
    public GameObject cat;
    public GameObject blackcat;
    public GameObject backcat;
    public Slider slider;
    public int movephase = 0;
    private bool isback = false;
    public void OnCilick()
    {
        //���݂̉摜���A�N�e�B�u���[�h��false�ɂ���
        background[movephase].SetActive(false);
        //���݂̃V�[�����X�V����
        movephase++;
        //���݂̉摜���A�N�e�B�u���[�h��true�ɂ���
        background[movephase].SetActive(true);
        Debug.Log(movephase);
        switch (movephase)
        {
            default:
                break;
            case 1:
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
    public void OnBackbuttonClick()
    {
        if (cat.activeInHierarchy)
        {
            isback = true;
            bt.gameObject.SetActive(false);
            backbt.SetActive(false);
            cat.SetActive(false);
        }

    }
    //�X�N���[���o�[
    IEnumerator Bar()
    {
        for (int i = 0; i <= 100; i++)
        {
            //�X�N���[���o�[�����炷
            slider.value -= 0.12f / 100;
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator Cat()
    {
        bt.interactable = false;
        //���L��\��������
        blackcat.SetActive(true);
        //��b��
        yield return new WaitForSeconds(1.5f);
        blackcat.SetActive(false);
        backcat.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        backcat.SetActive(false);
        bt.interactable = true;
    }
    //�t�F�[�Y�P�̏ꍇ
    void phese1()
    {

    }
    //�t�F�[�Y�Q�̏ꍇ
    void phese2()
    {
        //���L��\��������
        cat.SetActive(true);
        
    }
    //�t�F�[�Y�R�̏ꍇ
    void phese3()
    {
        //����isback���I���ɂȂ�����
        if (isback != true)
        {
            //back�{�^�����\��
            backbt.SetActive(false);
            //�L���\��
            cat.SetActive(false);
            StartCoroutine("Cat");
        }
        //�ق�
        else
        {
            //�L��\��������
            cat.SetActive(false);
        }
    }
    //�t�F�[�Y�S�̏ꍇ
    void phese4()
    {
        //�������L���\���������ꍇ
        if (blackcat.activeInHierarchy)
        {
            //�X�N���[���o�[�����炷
            StartCoroutine(Bar());
        }
        //���L���\��������
        blackcat.SetActive(false);
        //
        
    }
    //�t�F�[�Y�T�̏ꍇ
    void phese5()
    {
        //���L���\��������
        backbt.SetActive(false);
        //�{�^�����\��������
        bt.interactable = false;
        //�Q�b���start�V�[���ɑJ�ڂ���
        FadeManager.Instance.LoadScene("Start", 2.0f);
        
    }


}
