using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatScroll : MonoBehaviour
{
    private float scroll;
    public float speed = 10f;
    [SerializeField] private GameObject child1, child2, child3, child4, child5, child6, child7, child8, child9, child10, child11, child12, child13, child14, child15, child16, child17, child18, child19, child20, child21,
        child22, child23, child24, child25, child26, child27, child28, child29, child30, child31, child32, child33, child34, child35, child36, child37, child38, child39, child40, child41, child42, child43, child44, child45, child46, child47, child48, child49, child50;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.localPosition;
        scroll = Input.GetAxis("Mouse ScrollWheel");
        Debug.Log(scroll);
        pos.y = transform.localPosition.y - scroll * speed;
        if (pos.y < -6540)
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
        if (child18.activeInHierarchy && pos.y > -1070 && !child19.activeInHierarchy)
        {
            pos.y = -1070;
        }
        if (child19.activeInHierarchy && pos.y > -850 && !child20.activeInHierarchy)
        {
            pos.y = -850;
        }
        if (child20.activeInHierarchy && pos.y > -520 && !child21.activeInHierarchy)
        {
            pos.y = -520;
        }
        if (child21.activeInHierarchy && pos.y > -320 && !child22.activeInHierarchy)
        {
            pos.y = -320;
        }
        if (child22.activeInHierarchy && pos.y > -90 && !child23.activeInHierarchy)
        {
            pos.y = -90;
        }
        if (child23.activeInHierarchy && pos.y > 130 && !child24.activeInHierarchy)
        {
            pos.y = 130;
        }
        if (child24.activeInHierarchy && pos.y > 910 && !child25.activeInHierarchy)
        {
            pos.y = 910;
        }
        if (child25.activeInHierarchy && pos.y > 1185 && !child26.activeInHierarchy)
        {
            pos.y = 1185;
        }
        if (child26.activeInHierarchy && pos.y > 1485 && !child27.activeInHierarchy)
        {
            pos.y = 1485;
        }


        if (child27.activeInHierarchy && pos.y > 1485 && !child28.activeInHierarchy)
        {
            pos.y = 1730;
        }
        if (child28.activeInHierarchy && pos.y > 1940 && !child29.activeInHierarchy)
        {
            pos.y = 1940;
        }
        if (child29.activeInHierarchy && pos.y > 2210 && !child30.activeInHierarchy)
        {
            pos.y = 2210;
        }
        if (child30.activeInHierarchy && pos.y > 2990 && !child31.activeInHierarchy)
        {
            pos.y = 2990;
        }
        if (child31.activeInHierarchy && pos.y > 3300 && !child32.activeInHierarchy)
        {
            pos.y = 3300;
        }
        if (child32.activeInHierarchy && pos.y > 3560 && !child33.activeInHierarchy)
        {
            pos.y = 3560;
        }
        if (child33.activeInHierarchy && pos.y > 3810 && !child34.activeInHierarchy)
        {
            pos.y = 3810;
        }
        if (child34.activeInHierarchy && pos.y > 4160 && !child35.activeInHierarchy)
        {
            pos.y = 4160;
        }
        if (child35.activeInHierarchy && pos.y > 4380 && !child36.activeInHierarchy)
        {
            pos.y = 4380;
        }
        if (child36.activeInHierarchy && pos.y > 4660 && !child37.activeInHierarchy)
        {
            pos.y = 4660;
        }
        if (child37.activeInHierarchy && pos.y > 5440 && !child38.activeInHierarchy)
        {
            pos.y = 5440;
        }
        if (child38.activeInHierarchy && pos.y > 5665 && !child39.activeInHierarchy)
        {
            pos.y = 5665;
        }
        if (child39.activeInHierarchy && pos.y > 6040 && !child40.activeInHierarchy)
        {
            pos.y = 6040;
        }
        if (child40.activeInHierarchy && pos.y > 6360 && !child41.activeInHierarchy)
        {
            pos.y = 6360;
        }
        if (child41.activeInHierarchy && pos.y > 6620 && !child42.activeInHierarchy)
        {
            pos.y = 6620;
        }
        if (child42.activeInHierarchy && pos.y > 6875 && !child43.activeInHierarchy)
        {
            pos.y = 6875;
        }
        if (child43.activeInHierarchy && pos.y > 7625 && !child44.activeInHierarchy)
        {
            pos.y = 7625;
        }
        if (child44.activeInHierarchy && pos.y > 8045 && !child45.activeInHierarchy)
        {
            pos.y = 8045;
        }
        if (child45.activeInHierarchy && pos.y > 8345 && !child46.activeInHierarchy)
        {
            pos.y = 8345;
        }
        if (child46.activeInHierarchy && pos.y > 8600 && !child47.activeInHierarchy)
        {
            pos.y = 8600;
        }
        if (child47.activeInHierarchy && pos.y > 8850 && !child48.activeInHierarchy)
        {
            pos.y = 8850;
        }
        if (child48.activeInHierarchy && pos.y > 9050 && !child49.activeInHierarchy)
        {
            pos.y = 9050;
        }
        if (child49.activeInHierarchy && pos.y > 9050 && !child50.activeInHierarchy)
        {
            pos.y = 9530;
        }
        if (child50.activeInHierarchy && pos.y > 9780)
        {
            pos.y = 9780;
        }

        transform.localPosition = pos;
        
    }
}
