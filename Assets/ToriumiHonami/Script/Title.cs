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

        if (Input.GetKeyDown(KeyCode.UpArrow))  // 上ボタンを押したら
        {
            Debug.Log("ok");
            isMove = true;
        }

        if(isMove)
        {
            pos.y = Mathf.Lerp(this.transform.position.y, 1920f, speed * Time.deltaTime);   // 元の値から1920(画面の一番端)までの2点間を移動。
            this.transform.position = pos;

            Debug.Log("ok1");
        }
    }
}
/* スクリプト内容 */
// boolで起動
// 画面端まで移動
// 速度はiPhoneのを知らないので動画を見た結果このくらい