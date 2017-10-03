////////////////////////
//製作者　名越大樹
//製作日　10月2日
//プレイヤーがあったときに「CollisionManager」に通知するクラス
////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class PlayerCollision : MonoBehaviour
    {
        [SerializeField]
        CollisionManager collisionManagerScript;

        void OnTriggerEnter(Collider col)
        {
            collisionManagerScript.HitPlayer(gameObject, col.gameObject);
        }
    }
}
