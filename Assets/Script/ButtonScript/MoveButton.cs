using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveButton : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> background;
    [SerializeField]
    private Scrollbar scrollbar;
    [SerializeField]
    private Slider slider;
    private static int phase = 0;

    void Start()
    {
        // �X���C�_�[���擾����
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }
    public  void ChangeBackground()
    {
        //������
        /*for(int i = 0;i < background.Count;i++)
        {

            background[i].SetActive(false);
            
        }*/
        //�z�[���Q�[�W�̃o�[
        StartCoroutine(Bar());
        //���C�x�Q�[�W�̃o�[
        StartCoroutine(SlierBar());
        //���݂̉摜���A�N�e�B�u���[�h��false�ɂ���
        background[phase].SetActive(false);
        //���݂̃V�[�����X�V����
        phase++;
        Debug.Log(phase);
        //���݂̉摜���A�N�e�B�u���[�h��true�ɂ���
        background[phase].SetActive(true);
        

    }
    /// <summary>
    ///���͂������l�ɐ��l�̉摜�ɔ��
    /// </summary>
    /// <param name="i">�摜�̔ԍ�</param>
   �@public void Skip(int i)
    {
        background[phase].SetActive(false);
        phase = i;
        background[phase].SetActive(true);
    }
    public  int Getphase()
    {
        return phase;
    }
    public void Setphase(int index)
    {
        phase = index;
    }
    IEnumerator SlierBar()
    {
        for (int i = 0; i <= 100; i++)
        {
            slider.value -= 0.12f / 100;
            yield return new WaitForSeconds(0.01f);
        }
    }

   IEnumerator Bar()
    {
        for(int i = 0;i<=100;i++)
        {
            scrollbar.value += 0.12f/100;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
