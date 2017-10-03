//////////////////////
//製作者　名越大樹
//製作日　10月2日
//クラス名　プレイヤーの操作に関するクラス
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class PlayerAction : MonoBehaviour
    {
        [SerializeField]
        PlayerAnimation playerAnimationScript;
        [SerializeField]
        PlayerStatus playerStatusScript;
        int moveValue = 0;

        void Update()
        {
            Key();
            Move();
        }

        void Key()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Walk(true, 1);
            }

            else if (Input.GetKeyUp(KeyCode.D))
            {
                Walk(false, 0);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Walk(true, -1);
            }

            else if (Input.GetKeyUp(KeyCode.A))
            {
                Walk(false, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Event();
            }

            if(Input.GetKeyDown(KeyCode.Q))
            {
                Jump();
            }
        }

        /// <summary>
        /// 移動キーを押された時の処理
        /// </summary>
        void Walk(bool set, int value)
        {
            //アニメーションの処理開始
            playerStatusScript.SetIsWalk(set);
            playerAnimationScript.SetIsWalk();
            //アニメーションの処理終了
            Vector3 pos = transform.localScale;
            moveValue = value;
            if (value != 0)
            {
                pos.z = moveValue;
                transform.localScale = pos;
            }
        }

        void Move()
        {
            if (moveValue != 0)
            {
                float speed = playerStatusScript.GetSpeed() * Time.deltaTime * moveValue;
                transform.Translate(speed, 0.0f, 0.0f, Space.World);
            }
        }

        void Event()
        {
            Nagoshi.PlayerStatus.EventStatus result = playerStatusScript.GetEventStatus();
            if (result != PlayerStatus.EventStatus.none)
            {
                switch (result)
                {
                    case PlayerStatus.EventStatus.brige:
                        GameObject eventobj = playerStatusScript.GetEventObj();
                        eventobj.GetComponent<Nagoshi.EventStatus>().Action();
                        break;
                }
            }
        }

        void Jump()
        {
            if(playerStatusScript.GetIsJump())
            {
                float force = playerStatusScript.GetJumpForce();
                GetComponent<Rigidbody>().AddForce(Vector3.up * force );
                playerStatusScript.SetIsJump(false);
            }
        }
    }
}