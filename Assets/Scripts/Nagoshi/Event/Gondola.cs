////////////////////////////
//製作者　名越大樹
//製作日10月3日
//クラス名　ゴンドラに関するクラス
////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class Gondola : MonoBehaviour
    {
        [SerializeField]
        Nagoshi.Fook fookObj;

        public void SetDirection()
        {
            fookObj.SetDirection();
        }
    }
}
