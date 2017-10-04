//////////////////////////////////////
//制作　山根良太
//日付　10月4日
//内容　リザルト用スコア表示（テキストドキュメンとから読み込んでます）
//////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int hp;
    int score;
    int TotalScore = 0;
    
    public Text scoretxt;
   

    void Start()
    {

        //テキストファイルの中を読み込み
        //読み込む際に最初にAssetsから読み込んでもらう   Application.dataPath  = (Assets) 
        StreamReader sr = new StreamReader(Application.dataPath + "/Resources/score.txt");
        // Debug.Log("Test！");
        //一行読み込み
        string TotalScore = sr.ReadToEnd();
        scoretxt.text = TotalScore;

    }
    void Update()
    {
        //合計得点（リザルト時の得点）体力　*　スコア　=　トータルスコア
        TotalScore = hp * score;
        scoretxt.text = "Score:" +  TotalScore;
    }
}

