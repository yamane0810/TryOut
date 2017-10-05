/**
*   @Author YukiYamaji
*   @Day    17/10/3
*   @Brief  UI管理
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Yamaji.UI ui;                 //UIスクリプト
    [SerializeField]
    Nagoshi.PlayerManager playerScript; //プレイヤーマネージャー

    //所持金設定
    public void SetMoneyValue(int set)
    {
        ui.SetMoneyText(set);
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
