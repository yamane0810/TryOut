/////////////////////////
//製作者　名越大樹
//製作日　10月3日
//クラス名　ゲームステージで生成するオブジェクとを管理するクラス
/////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nagoshi
{
    public class InstanceManager : MonoBehaviour
    {

        [SerializeField]
        public GameObject[] InstanceObj;

        public GameObject InstanceObjects(int number, Vector3 pos)
        {
            GameObject obj = Instantiate(InstanceObj[number], pos, Quaternion.identity);
            return obj;
        }
    }
}
