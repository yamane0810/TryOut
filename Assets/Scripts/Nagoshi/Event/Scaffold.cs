///////////////////////////////
//製作者　名越大樹
//製作日　10月4日
//クラス名　櫓に関するクラス
///////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class Scaffold : MonoBehaviour
    {
        void OnTriggerEnter(Collider col)
        {
            if(col.gameObject.tag == "Stone")
            {
                Destroy(col.gameObject);
            }
        }

    }
}

