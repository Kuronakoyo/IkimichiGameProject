using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityDamage : MonoBehaviour
{
    [SerializeField]
    int maxHP = 100;
    [SerializeField]
    float currentHP;

    GameObject _sanityPoint;
    GameObject umaDamage;
    RandomUMA _randomUMA;

    void Start()
    {
        _sanityPoint = GameObject.Find("SanityPoint");
        umaDamage = GameObject.Find("UMAEvent");
        _randomUMA = umaDamage.GetComponent<RandomUMA>();
    }

    void Update()
    {
        _sanityPoint.GetComponent<SanityPoint>().HPDown(currentHP, maxHP);
    }


    public void OnClick()
    {
        if (_randomUMA.UMAFlag == true)
        {
            if (0 <= currentHP)
            {
                currentHP = maxHP - 35;
                maxHP = (int)currentHP;
            }
        }
    }

    public void LookdDown()
    {
        if (_randomUMA.UMAFlag == true)
        {
            if (0 <= currentHP)
            {
                currentHP = maxHP - 35;
                maxHP = (int)currentHP;
            }
        }
    }
}
