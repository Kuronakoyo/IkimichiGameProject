using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
   [SerializeField] float speed = 5;

    private bool isMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 pos = this.transform.position;

        if (Input.GetKeyDown(KeyCode.UpArrow))  // ��{�^������������
        {
            Debug.Log("ok");
            isMove = true;
        }

        if(isMove)
        {
            pos.y = Mathf.Lerp(this.transform.position.y, 1920f, speed * Time.deltaTime);   // ���̒l����1920(��ʂ̈�Ԓ[)�܂ł�2�_�Ԃ��ړ��B
            this.transform.position = pos;

            Debug.Log("ok1");
        }
    }
}
/* �X�N���v�g���e */
// bool�ŋN��
// ��ʒ[�܂ňړ�
// ���x��iPhone�̂�m��Ȃ��̂œ�����������ʂ��̂��炢