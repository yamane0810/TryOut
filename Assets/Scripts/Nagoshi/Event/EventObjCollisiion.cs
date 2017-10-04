////////////////////////////
//製作者　名越大樹
//製作日　10月3日
//クラス名　イベントのオブジェクトのあたり判定をコールするクラス
////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class EventObjCollisiion : MonoBehaviour
    {
        [SerializeField]
        CollisionManager collisonManagerScript;

        void OnTriggerEnter(Collider col)
        {
            if (gameObject.tag == "Fook")
            {
                GetComponent<Nagoshi.Fook>().SetDirection();
            }
        }
    }
}
