//////////////////////////
//製作者　名越大樹
//製作日　10月2日
//クラス名 プレイヤーを管理するクラス
//////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField]
        Nagoshi.GameMaster gameMaster;
        [SerializeField]
        Nagoshi.PlayerStatus playerStatusScript;

        public int GetMoney()
        {
            return playerStatusScript.GetMoney();
        }

        public int GetHp()
        {
            return playerStatusScript.GetHp();
        }

        public void SetMoney(int set)
        {
            playerStatusScript.SetMoney(set);
        }

        public void SetHp(int set)
        {
            playerStatusScript.SetHp(set);
        }
    }
}
