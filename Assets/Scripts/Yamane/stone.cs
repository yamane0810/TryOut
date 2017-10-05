///////////////////////////////////
//制作　山根良太
//日付  10月3日
//内容　ストーン生成
///////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    int cnt1 = 0;
    int cnt2 = 0;
    int cnt3 = 0;
    public GameObject createStone;
    public GameObject stonecube;
    Vector3 createPos;
    Vector3 stonePos;
    [SerializeField]
    float width;

    void Start()
    {
        createPos = createStone.transform.position;
        stonePos = stonecube.transform.position;
    }

    void Update()
    {

        cnt1++;
        cnt2++;
        cnt3++;
        if (cnt1 > 60)
        {
            stonePos.x = createPos.x + width;
            PosUpdate();
            Instantiate(stonecube, stonePos, Quaternion.identity);
            cnt1 = 0; new Vector3(-40.0f, 2.0f, 0.0f);
        }

        if (cnt2 > 80)
        {
            stonePos.x = createPos.x - width;
            PosUpdate();
            Instantiate(stonecube, stonePos, Quaternion.identity);
            cnt2 = 0;

        }
        if (cnt3 > 90)
        {
            stonePos.x = createPos.x;
            PosUpdate();
            Instantiate(stonecube, stonePos, Quaternion.identity);
            cnt3 = 0;
        }
    }

    void PosUpdate()
    {
        stonePos.y = transform.position.y;
    }
}
