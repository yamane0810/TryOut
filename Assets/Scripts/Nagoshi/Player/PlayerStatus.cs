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
        bool isTest = false;
        [SerializeField]
        int money;
        GameObject attachEventObj;
        bool isJump = true;
        float jumpForce;
        public enum EventStatus
        {
            none,
            brige,
            gondola,
            scafolld
        }
        [SerializeField]
        EventStatus eventStatus = EventStatus.none;

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

        public bool GetIsTest()
        {
            return isTest;
        }

        public void SetIsTest(bool set)
        {
            isTest = set;
        }

        public int GetMoney()
        {
            return money;
        }

        public void SetMoney(int set)
        {
            money = set;
        }

        public void SetEventStatus(EventStatus set)
        {
            eventStatus = set;
        }

        public EventStatus GetEventStatus()
        {
            return eventStatus;
        }

        public void SetEventObj(GameObject set)
        {
            attachEventObj = set;
            if (set != null)
            {
                EventStatus value = set.GetComponent<Nagoshi.EventStatus>().GetStatus();
                SetEventStatus(value);
            }
        }

        public GameObject GetEventObj()
        {
            return attachEventObj;
        }

        public void SetHp(int set)
        {
            hp = set;
        }

        public void SetIsJump(bool set)
        {
            isJump = set;
        }

        public bool GetIsJump()
        {
            return isJump;
        }

        public float GetJumpForce()
        {
            return jumpForce;
        }
    }
}
