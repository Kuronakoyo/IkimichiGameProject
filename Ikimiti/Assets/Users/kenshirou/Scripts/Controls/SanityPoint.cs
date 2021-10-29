using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityPoint : MonoBehaviour
{
    public Color color_1, color_2, color_3, color_4;
    public float maxHP = 100;
    [Range(0, 100)] public float hp = 100;
    private Image image_HPgauge;
    private float hp_ratio;

    RandomUMA umaPoint;
    // Start is called before the first frame update
    void Start()
    {
        image_HPgauge = GetComponent<Image>();
        umaPoint = gameObject.GetComponent<RandomUMA>();
    }

    // Update is called once per frame
    void Update()
    {
        hp_ratio = hp - maxHP;

        if (hp_ratio > 0.75f)
        {
            image_HPgauge.color = Color.Lerp(color_2, color_1, (hp_ratio - 0.75f) * 4f);
        }
        else if (hp_ratio > 0.25f)
        {
            image_HPgauge.color = Color.Lerp(color_3, color_2, (hp_ratio - 0.25f) * 4f);
        }
        else
        {
            image_HPgauge.color = Color.Lerp(color_4, color_3, hp_ratio * 4f);
        }

        image_HPgauge.fillAmount = hp_ratio;
    }

    public void Hp()
    {
        if(umaPoint.UMAFlag == true)
        {
            hp_ratio = hp - 35;
        }
    }
}
