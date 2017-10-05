/**
*   @Author YukiYamaji
*   @Day    17/10/4
*   @Brief  クロス演出
**/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yamaji
{
    public class Cross : MonoBehaviour
    {
        public GameObject cross;    //クロスエフェクト 

        void Update()
        {
            //回転後消滅
            cross.transform.Rotate(0.0f, 0.0f, 30.0f);
            Destroy(cross, 1.0f);    
        }
    }
}
