using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cat : MonoBehaviour
{
    //�X�^�[�g�ƏI���̖ڈ�
    public Transform startMarker;
    public Transform endMarker;

    // �X�s�[�h
    public float speed = 1.0F;

    //��_�Ԃ̋���������
    private float distance_two;
    // Start is called before the first frame update
    void Start()
    {
        //��_�Ԃ̋�������(�X�s�[�h�����Ɏg��)
        distance_two = Vector3.Distance(startMarker.position, endMarker.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
