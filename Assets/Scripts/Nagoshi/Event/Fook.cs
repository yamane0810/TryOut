////////////////////
//製作者　名越大樹
//製作日　10月3日
//クラス名　フックの動きに関するクラス
////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class Fook : MonoBehaviour
    {
        [SerializeField]
        float speed;
        int directionValue = 1;
        [SerializeField]
        GameObject gondolaObj;
        [SerializeField]
        float directionTime;
        float copytime;
        void Start()
        {
            copytime = directionTime;
        }

        void Update()
        {
            Move();
            Count();
        }

        void Move()
        {
            float sum = speed * Time.deltaTime * directionValue;
            transform.Translate(sum, 0, 0);
        }

        void Count()
        {
            directionTime = directionTime - Time.deltaTime;
            if(directionTime < 0)
            {
                directionValue = -directionValue;
                directionTime = -copytime;
            }
        }

        public void SetDirection()
        {
            directionValue = -directionValue;
        }

        public void InstanceGondola()
        {
            gondolaObj.SetActive(true);
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}