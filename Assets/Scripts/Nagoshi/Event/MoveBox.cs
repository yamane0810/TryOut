////////////////////////////
//製作者　名越大樹
//製作日　10月4日
//クラス名　MoveBoxの動きに関するクラス
////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class MoveBox : MonoBehaviour
    {
        [SerializeField]
        GameObject instancePos;
        [SerializeField]
        GameObject instanceMoveBox;
        [SerializeField]
        bool isSideMove;
        [SerializeField]
        bool isLengthMove;
        [SerializeField]
        float speed;
        [SerializeField]
        float time;
        float copytime;
        Vector3 movePos;
        // Use this for initialization
        void Start()
        {
            float length = 0;
            float side = 0;
            copytime = time;
            if (isLengthMove)
            {
                length = 1;
            }
            if (isSideMove)
            {
                side = 1;
            }
            movePos = new Vector3(side * speed, length * speed, 0.0f);
        }

        // Update is called once per frame
        void Update()
        {
            Move();
            Count();
        }

        void Move()
        {
            transform.Translate(movePos * Time.deltaTime);
        }

        void Count()
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                movePos = -movePos;
                time = copytime;
            }
        }

        /// <summary>
        /// 動きを止めて生成する
        /// </summary>
        public void Stop()
        {
            Instantiate(instanceMoveBox, instancePos.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        void OnCollisionEnter(Collision col)
        {
            if(col.gameObject.tag == "Player")
            {
                col.gameObject.transform.parent = transform;
            }
        }

        void OnCollisionExit(Collision col)
        {
            if (col.gameObject.tag == "Player")
            {
                col.gameObject.transform.parent = null;
            }
        }
    }
}