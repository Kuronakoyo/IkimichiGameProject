using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    public MoveButton mb;
    public int ButtonCount;
    private Animator anim;
    [SerializeField]
    private Button runbtn;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Run_click()
    {
        //�{�^���֐�������
        mb.runbtncount--;
        //�A�j���[�V�����̌Ăяo���̎��Ƀ{�^���̊֐�������
        anim.SetInteger("Count", mb.runbtncount);
        mb.ChangeBackground();

        StartCoroutine(ButtonOn());
       
    }
    IEnumerator ButtonOn()
    {
        yield return new WaitForSeconds(1.8f);
        //�[���ɂȂ�����{�^�����\���ɂ���
        if (mb.runbtncount == 0)
        {
            runbtn.interactable = false;
        }
       
       
    }
}
