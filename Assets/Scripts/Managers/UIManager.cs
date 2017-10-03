using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Yamaji.UITest UITestScript;
    [SerializeField]
    Nagoshi.PlayerManager playerScript;
    
    public void SetMoneyValue(int set)
    {
        UITestScript.SetMoneyText(set);
    } 

    public int GetMoneyValue()
    {
        return playerScript.GetMoney();
    }
}
