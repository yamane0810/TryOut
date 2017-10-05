/**
*   @Author YukiYamaji
*   @Day    17/10/4
*   @Brief  オーラ演出
**/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yamaji
{
    public class Aura : MonoBehaviour
    {
        public GameObject aura;     //オーラエフェクト 
        int cnt = 0;                //タイムカウント
        float enlargement = 0.7f;   //拡大
        float middle = 0.6f;        //中間 
        float reduction = 0.5f;     //縮小

        void Update()
        {
            //カウントアップ
            cnt++;
            //カウントの値に応じてエフェクト拡縮
            if (cnt < 2) aura.transform.localScale = new Vector3(middle, middle, 0);
            else if (cnt >= 2 && cnt < 6) aura.transform.localScale = new Vector3(enlargement, enlargement, 0);
            else if (cnt >= 6 && cnt < 9) aura.transform.localScale = new Vector3(middle, middle, 0);
            else if (cnt >= 9 && cnt < 12) aura.transform.localScale = new Vector3(reduction, reduction, 0);
            else if (cnt >= 12 && cnt < 15) aura.transform.localScale = new Vector3(middle, middle, 0);
            else if (cnt >= 15 && cnt < 18) aura.transform.localScale = new Vector3(enlargement, enlargement, 0);
            //一定カウントで消滅
            else Destroy(aura);
        }    
    }
}