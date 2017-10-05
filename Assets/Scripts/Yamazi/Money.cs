/**
*   @Author YukiYamaji
*   @Day    17/10/4
*   @Brief  金消費演出
**/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yamaji
{
    public class Money : MonoBehaviour
    {
        public GameObject money; //札束 
        Vector3 pos;             //現在位置
        Vector3 basePos;         //基準位置
        float cnt = 0.0f;        //カウント
        float speed = 3.0f;      //回転速度

        void Start()
        {
            pos = money.transform.position;
            basePos = pos;
        }

        void Update()
        {
            cnt += Time.deltaTime;
            money.transform.position = pos;
            //半円状位置移動後、消滅
            pos.x = basePos.x + Mathf.Sin(cnt - 2.0f) * -speed;
            pos.y = basePos.y + Mathf.Cos(cnt - 2.0f) * speed;
            Destroy(money, 1.0f);
        }
    }
}

