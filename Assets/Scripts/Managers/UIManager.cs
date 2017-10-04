/////////////////
//制作  山路優樹
//日付  10月3日
//説明  UI管理
/////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Yamaji.UI UITestScript;
    [SerializeField]
    Nagoshi.PlayerManager playerScript;

    //所持金設定
    public void SetMoneyValue(int set)
    {
        UITestScript.SetMoneyText(set);
    } 

    //所持金取得
    public int GetMoneyValue()
    {
        return playerScript.GetMoney();
    }

    //現在体力取得
    public int GetHpValue()
    {
        return playerScript.GetHp();
    }
}
