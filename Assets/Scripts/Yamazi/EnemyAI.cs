/////////////////
//制作  山路優樹
//日付  10月3日
//説明  敵UI管理
/////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yamaji
{
    public class EnemyAI : MonoBehaviour
    {
        Vector3 pos;         //現在位置
        Vector3 basePos;     //基準位置
        float speed = 2.0f;  //移動速度
        float cnt = 0.0f;    //行動切替時間

        //初期位置記憶
        void Start()
        {
            pos = transform.position;
            basePos = pos;
        }

        //行動変化処理
        void Update()
        {
            cnt += 1.0f * Time.deltaTime;
            transform.position = pos;

            if (cnt < 10.0f)
            {
                pos.x = basePos.x + -speed * Mathf.Cos(Time.time);
                pos.y = basePos.y + -speed * Mathf.Cos(Time.time);
            }
            else if(cnt >= 10.0f && cnt < 20.0f)
            {
                pos.x = basePos.x + speed * Mathf.Cos(Time.time);
                pos.y = basePos.y + -speed * Mathf.Cos(Time.time);
            }
            else if(cnt >= 20.0f && cnt < 30.0f)
            {
                pos.x = basePos.x + speed * Mathf.Sin(Time.time);
                pos.y = basePos.y + speed * Mathf.Cos(Time.time);
            }
            else if(cnt >= 30.0f && cnt < 40.0f)
            {
                pos.x = basePos.x + -speed * Mathf.Sin(Time.time);
            }
            else if (cnt >= 40.0f && cnt < 50.0f)
            {
                pos.y = basePos.y + speed * Mathf.Cos(Time.time);
            }
            else if (cnt >= 50.0f && cnt < 60.0f)
            {
                pos.x = basePos.x + speed * Mathf.Sin(Time.time);
                pos.y = basePos.y + speed / Mathf.Sin(Time.time);
            }
            else if (cnt >= 60.0f && cnt < 70.0f)
            {
                pos.x = basePos.x + speed * Mathf.Sin(Time.time);
                pos.y = basePos.y + speed * Mathf.Cos(Time.time);
            }
            else if (cnt >= 70.0f && cnt < 80.0f)
            {
                pos.x = basePos.x + -speed * Mathf.Sin(Time.time);
                pos.y = basePos.y + speed * Mathf.Cos(Time.time);
            }
            else if (cnt >= 80.0f && cnt < 90.0f)
            {
                pos.x = basePos.x + speed * Mathf.Sin(Time.time);
                pos.y = basePos.y + speed * Mathf.Cos(Time.time);
            }
            else if (cnt >= 90.0f && cnt < 100.0f)
            {
                pos.x = basePos.x + -speed * Mathf.Sin(Time.time);
                pos.y = basePos.y + speed * Mathf.Cos(Time.time);
            }
            else if (cnt >= 100.0f)
            {
                pos.x = basePos.x + speed / Mathf.Sin(Time.time);
            }
        }
    }
}
