/////////////////////
//製作者　名越大樹
//製作日　10月3日
//クラス名　プレイヤーの追従をするクラス
/////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAction : MonoBehaviour
{

    [SerializeField]
    GameObject playerObj;
    [SerializeField]
    Vector3 pos;
    [SerializeField]
    float posZ;
    [SerializeField]
    float posY;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        pos = playerObj.transform.position;
        pos.y += posY;
        pos.z = posZ;
        transform.position = pos;
    }

}
