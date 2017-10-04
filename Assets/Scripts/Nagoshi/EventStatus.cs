/////////////////////////
//製作者　名越大樹
//製作日　10月3日
//クラス名　イベントに関するステータスのクラス
/////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class EventStatus : MonoBehaviour
    {

        [SerializeField]
        Nagoshi.PlayerStatus.EventStatus eventstats;
        [SerializeField]
        GameObject InstanceObj;
        [SerializeField]
        GameObject InstancePos;
        [SerializeField]
        int rate;

        public Nagoshi.PlayerStatus.EventStatus GetStatus()
        {
            return eventstats;
        }

        public void Action()
        {
            switch (eventstats)
            {
                case Nagoshi.PlayerStatus.EventStatus.brige:
                    Instantiate(InstanceObj, InstancePos.transform.position, Quaternion.identity);
                    break;
            }
        }

        public int GetRate()
        {
            return rate;
        }

        public void SetRate()
        {

        }
    }
}
