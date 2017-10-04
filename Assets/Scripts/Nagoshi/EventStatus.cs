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
        GameObject EventObj;
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
                case Nagoshi.PlayerStatus.EventStatus.scaffold:
                    Instantiate(EventObj, InstancePos.transform.position, Quaternion.identity);
                    break;
                case Nagoshi.PlayerStatus.EventStatus.gondola:
                    EventObj.GetComponent<Fook>().InstanceGondola();
                    break;
            }
        }

        public int GetRate()
        {
            return rate;
        }

        public void SetRate(int set)
        {
            rate = set;
        }
    }
}
