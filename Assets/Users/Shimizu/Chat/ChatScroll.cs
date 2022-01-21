using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatScroll : MonoBehaviour
{
    private float scroll;
    public float speed = 10f;
    [SerializeField] private GameObject child1, child2, child3, child4, child5, child6, child7, child8, child9, child10, child11, child12, child13, child14, child15, child16, child17, child18, child19, child20, child21, child22, child23, child24, child25, child26, child27;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        scroll = Input.GetAxis("Mouse ScrollWheel");
        //Debug.Log(scroll);
        pos.y = transform.localPosition.y - scroll * speed;
        if(pos.y < -6540)
        {
            pos.y = -6540;
        }
        if (!child1.activeInHierarchy && pos.y > -6540)
        {
            pos.y = -6540;
        }
        if (child1.activeInHierarchy && pos.y > -6440 && !child2.activeInHierarchy)
        {
            pos.y = -6440;
        }
        if (child2.activeInHierarchy && pos.y > -6200 && !child3.activeInHierarchy)
        {
            pos.y = -6200;
        }
        if (child3.activeInHierarchy && pos.y > -5930 && !child4.activeInHierarchy)
        {
            pos.y = -5930;
        }
        if (child4.activeInHierarchy && pos.y > -5660 && !child5.activeInHierarchy)
        {
            pos.y = -5660;
        }
        if (child5.activeInHierarchy && pos.y > -5450 && !child6.activeInHierarchy)
        {
            pos.y = -5450;
        }
        if (child6.activeInHierarchy && pos.y > -4760 && !child7.activeInHierarchy)
        {
            pos.y = -4760;
        }
        if (child7.activeInHierarchy && pos.y > -4390 && !child8.activeInHierarchy)
        {
            pos.y = -4390;
        }
        if (child8.activeInHierarchy && pos.y > -4130 && !child9.activeInHierarchy)
        {
            pos.y = -4130;
        }
        if (child9.activeInHierarchy && pos.y > -3820 && !child10.activeInHierarchy)
        {
            pos.y = -3820;
        }
        if (child10.activeInHierarchy && pos.y > -3610 && !child11.activeInHierarchy)
        {
            pos.y = -3610;
        }
        if (child11.activeInHierarchy && pos.y > -3360 && !child12.activeInHierarchy)
        {
            pos.y = -3360;
        }
        if (child12.activeInHierarchy && pos.y > -2990 && !child13.activeInHierarchy)
        {
            pos.y = -2990;
        }
        if (child13.activeInHierarchy && pos.y > -2740 && !child14.activeInHierarchy)
        {
            pos.y = -2740;
        }
        if (child14.activeInHierarchy && pos.y > -2520 && !child15.activeInHierarchy)
        {
            pos.y = -2520;
        }
        if (child15.activeInHierarchy && pos.y > -2260 && !child16.activeInHierarchy)
        {
            pos.y = -2260;
        }
        if (child16.activeInHierarchy && pos.y > -2060 && !child17.activeInHierarchy)
        {
            pos.y = -2060;
        }
        if (child17.activeInHierarchy && pos.y > -1840 && !child18.activeInHierarchy)
        {
            pos.y = -1840;
        }
        if (child18.activeInHierarchy && pos.y > -1000 && !child19.activeInHierarchy)
        {
            pos.y = -1000;
        }
        if (child19.activeInHierarchy && pos.y > -1090 && !child20.activeInHierarchy)
        {
            pos.y = -1090;
        }
        if (child20.activeInHierarchy && pos.y > 200 && !child21.activeInHierarchy)
        {
            pos.y = 200;
        }
        if (child21.activeInHierarchy && pos.y > 550)
        {
            pos.y = 550;
        }
        if (child22.activeInHierarchy && pos.y > 1000)
        {
            pos.y = 1000;
        }
        if (child23.activeInHierarchy && pos.y > 2000)
        {
            pos.y = 2000;
        }
        if (child24.activeInHierarchy && pos.y > 2600)
        {
            pos.y = 2600;
        }
        if (child25.activeInHierarchy && pos.y > 3100)
        {
            pos.y = 3100;
        }
        if (child26.activeInHierarchy && pos.y > 3600)
        {
            pos.y = 3600;
        }
        if (child27.activeInHierarchy && pos.y > 4100)
        {
            pos.y = 4100;
        }
        transform.localPosition = pos;
        
    }
}
