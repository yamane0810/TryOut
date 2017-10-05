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
    public class Use : MonoBehaviour
    {
        public GameObject player;   //プレイヤーオブジェ
        [SerializeField]
        EffectManager effectScript; //エフェクトマネージャー

        void Start()
        {
            //プレイヤー位置取得
            Vector3 pos = player.transform.position;
            //各エフェクト生成
            effectScript.InstanceEffect(0, pos + new Vector3(-30.0f, 15.0f, -2.5f));
            effectScript.InstanceEffect(1, pos + new Vector3(0.0f, 0.3f, 0.0f));
            effectScript.InstanceEffect(2, pos + new Vector3(0.5f, 1.0f, -0.5f));
            effectScript.InstanceEffect(3, pos + new Vector3(-2.5f, -0.1f, 0.0f));
        }

    }
}
