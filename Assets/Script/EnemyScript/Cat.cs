using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cat : MonoBehaviour
{
    //スタートと終わりの目印
    public Transform startMarker;
    public Transform endMarker;

    // スピード
    public float speed = 1.0F;

    //二点間の距離を入れる
    private float distance_two;
    // Start is called before the first frame update
    void Start()
    {
        //二点間の距離を代入(スピード調整に使う)
        distance_two = Vector3.Distance(startMarker.position, endMarker.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
