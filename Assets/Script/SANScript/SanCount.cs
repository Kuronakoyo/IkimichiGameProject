using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SanCount : MonoBehaviour
{

    [SerializeField]
    private Dictionary<CommonGameDataModel.SanSubParam, int> _sanSubTable = new Dictionary<CommonGameDataModel.SanSubParam, int>()
    {
        {CommonGameDataModel.SanSubParam.Normal, 1},
        {CommonGameDataModel.SanSubParam.cats, 2},
        {CommonGameDataModel.SanSubParam.RedHand, 10},
        {CommonGameDataModel.SanSubParam.spSE, 1},
        {CommonGameDataModel.SanSubParam.SP, 4},
        {CommonGameDataModel.SanSubParam.farSP, 3},
        {CommonGameDataModel.SanSubParam.farkunekune, 3},
        {CommonGameDataModel.SanSubParam.kunekune, 5},
        {CommonGameDataModel.SanSubParam.UmaSE, 1},
        {CommonGameDataModel.SanSubParam.Uma, 15},
        {CommonGameDataModel.SanSubParam.Ghost, 10},
        {CommonGameDataModel.SanSubParam.kusaSE, 1},
        {CommonGameDataModel.SanSubParam.Ghostshadow, 3},
        {CommonGameDataModel.SanSubParam.karasuSE, 1},
        {CommonGameDataModel.SanSubParam.GrilSE, 1},
        {CommonGameDataModel.SanSubParam.Ghostbyo, 2},
    };

    public Slider scoreSlider;
    [SerializeField]
    private Text _scoreObjectText = null;
    public bool _sangameover = false;
    // Start is called before the first frame update
    void Start()
    {
        CommonGameDataModel.DispSanScore(_scoreObjectText);
        // スコアのロード
        scoreSlider.value = CommonGameDataModel.GetSanSlider();
    }

    public bool SubSanScore(CommonGameDataModel.SanSubParam sanSubParam)
    {
        _sangameover = true;
        return CommonGameDataModel.SubSanScore(_scoreObjectText, _sanSubTable[sanSubParam]);
    }
}
