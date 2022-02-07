using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommonGameDataModel
{
    public enum SanSubParam
    {
        Normal = 0,
        cats,
        RedHand,
        spSE,
        SP,
        farSP,
        farkunekune,
        kunekune,
        UmaSE,
        Uma,
        Ghost,
        kusaSE,
        Ghostshadow,
        karasuSE,
        GrilSE,
        Ghostbyo,
    }

    //  SAN値
    public static int SanScore { get; private set; } = 0;

    private const int _maxSanScore = 80;

    public static void SetSanInitial()
    {
        SanScore = _maxSanScore;
    }

    public static float GetSanSlider()
    {
        return ((float)SanScore / (float)_maxSanScore);
    }

    //  SAN値設定
    public static void SetSanScore(Text text, int sanScore)
    {
        if (null == text)
            return;
        SanScore = sanScore;
        text.text = sanScore.ToString();
    }

    public static void DispSanScore(Text text)
    {
        if (null == text)
            return;
        text.text = SanScore.ToString();
    }

    public static bool SubSanScore(Text text, int subCount)
    {
        SanScore -= subCount;
        if (SanScore > 0) SanScore = 0;
        DispSanScore(text);
        return 0 == SanScore;
    }
}
