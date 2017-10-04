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
        int playerHp;                       //現在体力
        int playerMaxHp;                    //最大体力
        int playerMoney;                    //現在所持金
        int playerMaxMoney;                 //最大所持金
        public Image imageDamage;           //ダメージ演出画像
        public Text textMoney;              //所持金テキスト
        public UIManager uiManagerScript;   //UIマネージャー取得
        public Nagoshi.PlayerStatus playerStatus;
 
        //初期化処理
        void Start()
        {
            playerMaxHp = playerStatus.GetMaxHp();
            playerHp = playerStatus.GetHp();
            playerMaxMoney = playerStatus.GetMaxMoney();
            playerMoney = playerStatus.GetMoney();
            SetMoneyText(playerMoney);
        }

        //HPゲージ管理
        public void HpGauge(int hp)
        {
            Debug.Log(playerHp);
            //最大体力とダメージを比べて、異なっていれば徐々に減算
            float hpPercentage = (float)playerMaxHp / hp * 1.0f;
            //ゲージの長さを体力の割合により伸縮
            imageDamage.transform.localScale = new Vector3(6.0f, hpPercentage, 1.0f);
        }

        //表示所持金セット
        public void SetMoneyText(int setValue)
        {
            Debug.Log(setValue);
            textMoney.text = setValue.ToString();
            textMoney.text = string.Format("{0:0,000}", setValue);
            //所持金値制限
            playerMoney = (int)Mathf.Clamp(playerMoney, 0, playerMaxMoney);
        }
    }
}