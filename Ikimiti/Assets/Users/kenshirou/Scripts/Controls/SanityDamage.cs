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

    GameObject hpSystem;

    void Start()
    {
        hpSystem = GameObject.Find("SanityPoint");
    }

    void Update()
    {
        //hpSystem.GetComponent<SanityPoint>().HPDown(currentHP, maxHP);
    }

    void FixedUpdate()
    {
        if(0 <= currentHP)
        {
            currentHP = maxHP - Time.time * 10;
        }
    }
}
