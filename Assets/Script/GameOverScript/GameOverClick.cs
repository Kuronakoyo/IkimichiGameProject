using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverClick : MonoBehaviour
{
    [SerializeField]
    GameObject Panelfade;       // �t�F�[�h�p�l���̎擾

    public float speed = 0.01f; // �������̑���

    private float alpha;        // ���l�𑀍삷�邽�߂̕ϐ�

    private bool fadeFlag;      // �t�F�[�h�C���̃t���O

    Image fadealpha;            // �t�F�[�h�p�l���̃C���[�W�擾�ϐ�

    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>();    // �p�l���̃C���[�W�擾
        alpha = fadealpha.color.a;                      // �p�l���̃��l���擾
        fadeFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeFlag == true)
        {
            FadeIn();
        }
    }
 
    void FadeIn()
    {
        alpha -= speed;
        fadealpha.color = new Color(0, 0, 0, alpha);

        if(alpha <= 0)
        {
            fadeFlag = false;
            Panelfade.SetActive(false);
        }
    }

    
}
