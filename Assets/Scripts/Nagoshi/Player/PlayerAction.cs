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
                Walk(true,1);
            }

            else if(Input.GetKeyUp(KeyCode.D))
            {
                Walk(false,0);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Walk(true,-1);
            }

            else if (Input.GetKeyUp(KeyCode.A))
            {
                Walk(false,0);
            }
        }

        /// <summary>
        /// 移動キーを押された時の処理
        /// </summary>
        void Walk(bool set,int value)
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
            if(moveValue != 0)
            {
                float speed = playerStatusScript.GetSpeed() * Time.deltaTime * moveValue;
                transform.Translate(speed, 0.0f, 0.0f, Space.World);
            }
        }
    }
}