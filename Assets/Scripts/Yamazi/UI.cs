/////////////////
//制作  山路優樹
//日付  10月2日
//説明  UI処理
/////////////////

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
        int money;                          //現在所持金
        int maxMoney = 9999;                //最大所持金
        public Image hpImage;               //HPゲージ
        public Text moneyText;              //所持金
        public UIManager uiManagerScript;   //UIマネージャー取得

        //初期化処理
        void Start()
        {
            uiManagerScript.SetMoneyValue(money);
            money = uiManagerScript.GetMoneyValue();
            hp = uiManagerScript.GetHpValue();
            displayHp = hp;
            Money();
            HpGauge(displayHp);
        }

        //HPゲージ管理
        public void HpGauge(int hp)
        {
            Debug.Log(hp);
            //現在体力と比較用体力を比べて、異なっていれば徐々に減算
            if (displayHp != hp) displayHp = (int)Mathf.Lerp(displayHp, hp, 0.1f);
            //現在体力の割合により文字色変化
            float HpPercentage = (float)displayHp / maxHp;
            if (HpPercentage > 0.5f) hpImage.color = Color.green;
            else if (HpPercentage > 0.3f) hpImage.color = Color.yellow;
            else hpImage.color = Color.red;
            //ゲージの長さを体力の割合により伸縮
            hpImage.transform.localScale = new Vector3(HpPercentage, 1, 1);
        }

        //所持金テキスト管理
        void Money()
        {
            //書式設定
            moneyText.text = string.Format("{0:0000}", money);
            //所持金値制限
            money = (int)Mathf.Clamp(money, 0, maxMoney);
        }

        //表示所持金セット
        public void SetMoneyText(int setValue)
        {
            moneyText.text = setValue.ToString();
        }
    }
}