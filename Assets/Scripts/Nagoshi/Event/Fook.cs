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

        void Update()
        {
            Move();
        }

        void Move()
        {
            float sum = speed * Time.deltaTime * directionValue;
            transform.Translate(sum, 0, 0);
        }

        public void SetDirection()
        {
            directionValue = -directionValue;
        }

        public void InstanceGondola()
        {
            gondolaObj.SetActive(true);
            GetComponent<BoxCollider>().size = gondolaObj.transform.localScale;
        }
    }
}