/////////////////
//制作  山路優樹
//日付  10月2日
//説明  ギミックスイッチ処理
/////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Yamaji
{
    public class GimmickSwitch : MonoBehaviour
    {
        int cnt = 0;                      //カウント変数
        public GameObject gimmickSwitch;  //スイッチオブジェクト

        void Start()
        {
            //表示を切っておく
            gimmickSwitch.SetActive(false);
        }

        void Update()
        {
            cnt += 1;
        }

        //スイッチ出現処理
        void Appear()
        {
            if (cnt > 60) gimmickSwitch.SetActive(true);
        }
    }
}
