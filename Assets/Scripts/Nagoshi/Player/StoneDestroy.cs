///////////////////
///////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneDestroy : MonoBehaviour {

    //オブジェクトがプレイヤーのカメラ外に行くとオブジェクトを削除していく
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
