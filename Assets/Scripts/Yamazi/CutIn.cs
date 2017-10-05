/**
*   @Author YukiYamaji
*   @Day    17/10/4
*   @Brief  カットイン演出
**/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yamaji
{
    public class CutIn : MonoBehaviour
    {
        public GameObject cutIn;    //カットイン
        float cnt = 0.0f; 

        void Update()
        {
            cnt += Time.deltaTime;
            //左上からスライドイン右下にスライドアウト後消滅
            if (cnt < 0.22f) cutIn.transform.Translate(3.0f, -1.5f, 0.0f);
            else if (cnt >= 0.22f && cnt < 1.2f) cutIn.transform.Translate(0.005f, -0.005f, 0.0f);
            if (cnt >= 1.2f) cutIn.transform.Translate(3.0f, -1.5f, 0.0f);
            Destroy(cutIn, 5.0f);
        }
    }
}

