using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Textv : MonoBehaviour
{
    [SerializeField] List<string> messageList = new List<string>();//��b�����X�g
    [SerializeField] Text text;
    [SerializeField] float novelSpeed;//�ꕶ���ꕶ���̕\�����鑬��
    int novelListIndex = 0; //���ݕ\�����̉�b���̔z��


    void Start()
    {
        StartCoroutine(Novel());
    }


    private IEnumerator Novel()
    {
        int messageCount = 0; //���ݕ\�����̕�����
        text.text = ""; //�e�L�X�g�̃��Z�b�g
        while (messageList[novelListIndex].Length > messageCount)//���������ׂĕ\�����Ă��Ȃ��ꍇ���[�v
        {
            text.text += messageList[novelListIndex][messageCount];//�ꕶ���ǉ�
            messageCount++;//���݂̕�����
            yield return new WaitForSeconds(novelSpeed);//�C�ӂ̎��ԑ҂�
        }
    }
  }
