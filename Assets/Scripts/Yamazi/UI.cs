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
        int damage;                         //ダメージ
        int money;                          //現在所持金
        int maxMoney = 9999;                //最大所持金
        public Image imageDamage;           //ダメージ演出画像
        public Text textMoney;              //所持金テキスト
        //public Sprite sprite;             //分割前スプライト
        //public Sprite[] SpriteArray;      //各スプライト格納配列
        public UIManager uiManagerScript;   //UIマネージャー取得
        
        //初期化処理
        void Start()
        {
            uiManagerScript.SetMoneyValue(money);
            money = uiManagerScript.GetMoneyValue();
            hp = uiManagerScript.GetHpValue();
            damage = maxHp - hp;
            Money();
            HpGauge(damage);
        }

        //HPゲージ管理
        public void HpGauge(int hp)
        {
            //最大体力とダメージを比べて、異なっていれば徐々に減算
            float hpPercentage = (float)maxHp / hp * 1.0f;
            //ゲージの長さを体力の割合により伸縮
            imageDamage.rectTransform.localScale = new Vector3(6.0f, hpPercentage, 1.0f);
        }

        //所持金管理
        void Money()
        {
            textMoney.text = string.Format("{0:0,000}", money);
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