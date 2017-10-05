////////////////////
//製作者 名越大樹
//製作日　10月4日
//クラス名　エレベータの動きに関するクラス
////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class Elevator : MonoBehaviour
    {
        [SerializeField]
        float speed;
        [SerializeField]
        float maxvalue = 1;
        [SerializeField]
        float minvalue = -1;
        public void Move(float value)
        {
            float movevalue = 0.0f;
            if (value < 0)
            {
                movevalue = minvalue;
            }

            else
            {
                movevalue = maxvalue;
            }
            Vector3 pos = transform.position;
            pos.y += movevalue * speed * Time.deltaTime;
            transform.position = pos;
        }

        void OnTriggerEnter(Collider col)
        {
            Debug.Log(col.gameObject.tag);
            if(col.gameObject.tag == "MaxElevator")
            {
                maxvalue = 0.0f;
            }

            else if(col.gameObject.tag == "MinElevator")
            {
                minvalue = 0.0f;
            }
        }

        void OnTriggerExit(Collider col)
        {
            if (col.gameObject.tag == "MaxElevator")
            {
                maxvalue = 1.0f;
            }

            else if (col.gameObject.tag == "MinElevator")
            {
                minvalue = -1.0f;
            }
        }

        /// <summary>
        /// プレイヤーに当たったときだけ
        /// </summary>
        /// <param name="col"></param>
        void OnCollisionEnter(Collision col)
        {
            if(col.gameObject.tag == "Player")
            {
                col.gameObject.transform.parent = transform.parent;
                col.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                transform.position = transform.position;
                col.gameObject.GetComponent<Nagoshi.PlayerStatus>().SetIsElevetorAction(true);
                col.gameObject.GetComponent<Nagoshi.PlayerStatus>().SetElevator(GetComponent<Nagoshi.Elevator>());
            }
        }

        /// <summary>
        /// プレイヤーとの衝突が離れた時
        /// </summary>
        void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                col.gameObject.transform.parent =　null;
                col.gameObject.GetComponent<Nagoshi.PlayerStatus>().SetIsElevetorAction(false);
                col.gameObject.GetComponent<Nagoshi.PlayerStatus>().SetElevator(null);
            }
        }
    }
}