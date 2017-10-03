//////////////////////
//製作者　名越大樹
//製作日　10月2日
//クラス名　あたり判定の処理をするクラス　
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {
    /// <summary>
    /// プレイやーがほかのオブジェクト衝突した時の処理
    /// </summary>
    public void HitPlayer(GameObject playerobj,GameObject hitobj)
    {
        //宝箱(coin)がプレイヤーに当たった時を宝箱を消す
        if (hitobj.gameObject.tag == "coin")
        {   
            Destroy(hitobj);
        }
    }
}
