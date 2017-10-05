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
        [SerializeField]
        Nagoshi.PlayerStatus playerStatusScript;

        void OnTriggerEnter(Collider col)
        {
            Debug.Log(col.gameObject.tag);
            collisionManagerScript.HitPlayer(gameObject, col.gameObject);
        }

        void OnCollisionEnter(Collision col)
        {
            collisionManagerScript.HitCollision(gameObject,col.gameObject);
        }

        void OnTriggerExit(Collider col)
        {
            collisionManagerScript.ExitPlayer(gameObject, col.gameObject);
        }

        void OnTriggerStay(Collider col)
        {
            collisionManagerScript.StayCollision(gameObject,col.gameObject);
        }

        void OnCollisionExit(Collision col)
        {
            collisionManagerScript.ExitCollsion(gameObject, col.gameObject);
        }
    }
}
