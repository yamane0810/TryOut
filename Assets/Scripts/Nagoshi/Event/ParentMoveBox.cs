//////////////////////
//製作者　名越大樹
//製作日　10月4日
//クラス名　MoveBoxのオブジェクトを管理するクラス
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class ParentMoveBox : MonoBehaviour
    {

        [SerializeField]
        Nagoshi.MoveBox[] moveBoxObjects;

        public void StopMoveBox()
        {
            Debug.Log("hoge");
            for (int count = 0; count < moveBoxObjects.Length; count++)
            {
                    moveBoxObjects[count].Stop();
            }
        }
    }
}