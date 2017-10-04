/////////////////
//制作  山路優樹
//日付  10月2日
//説明  UI処理
/////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Yamaji
{
    public class UI : MonoBehaviour
    {
        int hp;                             //現在体力
        int maxHp = 100;                    //最大体力
        int displayHp;                      //比較用体力
        int damageHp;                       //比較用ダメージ
        int money;                          //現在所持金
        int maxMoney = 9999;                //最大所持金
        public Image imageHp;               //HP
        public Image imageDamage;           //ダメージ
        public UIManager uiManagerScript;   //UIマネージャー取得
        
        //初期化処理
        void Start()
        {
            uiManagerScript.SetMoneyValue(money);
            money = uiManagerScript.GetMoneyValue();
            hp = uiManagerScript.GetHpValue();
            displayHp = hp;
            damageHp = maxHp - hp;
            Money();
            HpGauge(displayHp);
        }

        //HPゲージ管理
        public void HpGauge(int hp)
        {
            //現在体力と比較用体力を比べて、異なっていれば徐々に減算
            if (displayHp != hp) displayHp = (int)Mathf.Lerp(displayHp, hp, 0.1f);
            //if (damageHp != maxHp) damageHp = (int)Mathf.Lerp(damageHp, maxHp, 0.1f);
            //現在体力の割合により文字色変化
            float hpPercentage = (float)displayHp / maxHp * 2.5f;
            //float damagePercentage = (float)damageHp / maxHp;
            //ゲージの長さを体力の割合により伸縮
            imageHp.transform.localScale = new Vector3(0.5f, hpPercentage, 1);
            //imageDamage.transform.localScale = new Vector3(1.0f, damagePercentage, 1);
        }

        //所持金テキスト管理
        void Money()
        {
            MoneyUI numSprite = GetComponent<MoneyUI>();
            numSprite.Value = money; //ここで表示数値指定
            //所持金値制限
            money = (int)Mathf.Clamp(money, 0, maxMoney);
        }

        //表示所持金セット
        public void SetMoneyText(int setValue)
        {
            Debug.Log(money);
        }
    }
}