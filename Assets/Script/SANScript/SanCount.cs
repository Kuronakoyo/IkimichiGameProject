using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SanCount : MonoBehaviour
{
    
    public Slider scoreSlider;
    public GameObject score_object = null; //�e�L�X�g�I�u�W�F�N�g
    public int score_num = 0;//�X�R�A�ϐ�
   
    // Start is called before the first frame update
    void Start()
    {

        
        if (SceneManager.GetActiveScene().name == "Day1")
        {
            score_num = 80;
        }
        
        if(SceneManager.GetActiveScene().name == "Day2")
        {
            // �X�R�A�̃��[�h
            score_num = PlayerPrefs.GetInt("SCORE", 0);
            scoreSlider.value = PlayerPrefs.GetFloat("OptionScore",0);
        }
        if (SceneManager.GetActiveScene().name == "Day3")
        {
            // �X�R�A�̃��[�h
            score_num = PlayerPrefs.GetInt("SCORE", 0);
            scoreSlider.value = PlayerPrefs.GetFloat("OptionScore", 0);
        }
        if (SceneManager.GetActiveScene().name == "Day4")
        {
            // �X�R�A�̃��[�h
            score_num = PlayerPrefs.GetInt("SCORE", 0);
            scoreSlider.value = PlayerPrefs.GetFloat("OptionScore", 0);
        }
        if (SceneManager.GetActiveScene().name == "Day5")
        {
            // �X�R�A�̃��[�h
            score_num = PlayerPrefs.GetInt("SCORE", 0);
            scoreSlider.value = PlayerPrefs.GetFloat("OptionScore", 0);
        }
        
    }
  
    // Update is called once per frame
    void Update()
    {

        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "" + score_num;

        Save();


    }

 

    public void Save()
    {
        // �X�R�A��ۑ�
        PlayerPrefs.SetInt("SCORE", score_num);
        //
        PlayerPrefs.SetFloat("OptionScore", scoreSlider.value);
        PlayerPrefs.Save();
    }
    public void SE()
    {
        score_num -= 1;
    }
    public void cats()
    {
        score_num -= 2;
    }
    public void RedHand()
    {
        score_num -= 5;
    }
    public void spSE()
    {
        score_num -= 1;
    }
    public void SP()
    {
        score_num -= 4;
    }
    public void farSP()
    {
        score_num -= 3;
    }
    public void farkunekune()
    {
        score_num -= 3;
    }
    public void kunekune()
    {
        score_num -= 5;
    }
    public void UmaSE()
    {
        score_num -= 1;
    }
    public void Uma()
    {
        score_num -= 10;
    }
    public void Ghost()
    {
        score_num -= 10;
    }
    public void kusaSE()
    {
        score_num -= 1;
    }
    public void Ghostshadow()
    {
        score_num -= 3;
    }
    public void karasuSE()
    {
        score_num -= 1;
    }
    public void GrilSE()
    {
        score_num -= 1;
    }
    public void Ghostbyo()
    {
        score_num -= 2;
    }
}
