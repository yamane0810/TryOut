using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    Nagoshi.PlayerStatus playerScript;
    int hp;                     //現在体力
    int maxHp = 100;            //最大体力
    int money = 0;              //現在所持金
    int maxMoney = 9999;        //最大所持金
    public Text hpText;         //HP
    public Text moneyText;      //所持金

    void Start ()
    {
        hp = playerScript.GetHp();
	}
	
	void Update ()
    {
		//hpText.text = string.Format("{0:000}", hp);
        //moneyText.text = string.Format("{0:000}", money);
    }
}
