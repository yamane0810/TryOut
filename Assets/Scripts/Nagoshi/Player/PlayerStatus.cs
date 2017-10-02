///////////////////////
//製作者　名越大樹
//製作日　10月2日
//クラス名　プレイヤーのステータスを管理するクラス
///////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class PlayerStatus : MonoBehaviour
    {
        [SerializeField]
        int hp;
        [SerializeField]
        int speed;
        bool isWalk = false;

        public int GetHp()
        {
            return hp;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void SetIsWalk(bool set)
        {
            isWalk = set;
        }

        public bool GetIsWalk()
        {
            return isWalk;
        }

    }
}
