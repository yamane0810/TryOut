/////////////////
//制作  山路優樹
//日付  10月2日
//説明  UI管理
/////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Yamaji
{
    public class UITest : MonoBehaviour
    {
        int hp;                     //現在体力
        int maxHp = 100;            //最大体力
        int displayHp;              //比較用体力
        int money = 0;              //現在所持金
        int maxMoney = 10000;       //最大所持金
        float step = 0.0f;          //進行度
        float maxStep = 1.0f;       //最終地点
        bool isUpDown = false;      //移動フラグ
        public Image hpImage;       //HPゲージ
        public Image corsol;        //進行度カーソル
        public Text moneyText;      //所持金
        public Scrollbar stepBar;   //進行度バー

        void Start()
        {
            hp = maxHp;
            displayHp = hp;
        }

        void Update()
        {
            HpGauge();
            Money();
            Step();
            if (Input.anyKeyDown) hp -= 10;
        }

        //HPゲージ管理
        void HpGauge()
        {
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
            moneyText.text = string.Format("{0:00000} / {1:00000}", money, maxMoney);
            money += 1;
            //所持金値制限
            money = (int)Mathf.Clamp(money, 0, maxMoney);
        }

        //進行度管理
        void Step()
        {
            //進行度上昇
            stepBar.value = step;
            step += (float)0.1 * Time.deltaTime;
            //進行度カーソル回転
            corsol.transform.Rotate(10.0f, 0.0f, 0.0f);
        }
    }
}