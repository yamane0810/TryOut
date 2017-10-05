/////////////////////
//製作者　名越大樹
//製作日　10月3日
//クラス名　ゲームすてーじで使用するエフェクトを管理するクラス
/////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{

    [SerializeField]
    GameObject[] effectObj;

    public void InstanceEffect(int number,Vector3 pos)
    {
        Instantiate(effectObj[number],pos,Quaternion.identity);
    }
}
