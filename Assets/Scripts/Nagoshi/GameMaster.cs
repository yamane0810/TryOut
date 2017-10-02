//////////////////////////
//製作者　名越大樹
//製作日　10月2日
//クラス名　ゲームの進行を管理するクラス
//////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class GameMaster : MonoBehaviour
    {
        bool isGamePlay;

        public bool GetIsGamePlay()
        {
            return isGamePlay;
        }
    }
}
