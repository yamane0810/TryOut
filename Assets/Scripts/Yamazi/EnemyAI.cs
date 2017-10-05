/**
*   @Author YukiYamaji
*   @Day    17/10/3
*   @Brief  敵行動管理
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yamaji
{
    public class EnemyAI : MonoBehaviour
    {
        //オブジェクト自身
        public GameObject enemy;
        //オブジェクト座標
        Vector3 pos;
        //移動速度
        float moveSpeed = 2.0f;
        //回転速度
        float angleSpeed = 0.1f;
        //半径(8の字移動の大きさ)
        float radius = 4.5f;

        void Start()
        {
            //初期自身位置記憶
            pos = enemy.transform.position;
        }

        void Update()
        {
            RotateAxis();
            MovePos();
        }

        //回転処理
        void RotateAxis()
        {
            transform.Rotate(0, angleSpeed, 0);
        }

        //自身位置を基準に移動処理
        void MovePos()
        {
            //経過時間取得
            float time = Time.time;
            //８の字移動
            float x = pos.x + Mathf.Cos(time * moveSpeed) * radius;
            float y = pos.y + Mathf.Sin(time * moveSpeed * 2) * radius / 3; ;
            float z = 0.0f;
            //座標代入
            transform.position = new Vector3(x, y, z);
        }
    }
}
