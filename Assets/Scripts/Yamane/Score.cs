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
    public Text money;
    public Text life;
    public Text ts;


    void Start()
    {
        //テキストファイルの中を読み込み
        //読み込む際に最初にAssetsから読み込んでもらう   Application.dataPath  = (Assets) 
        StreamReader sr = new StreamReader(Application.dataPath + "/Resources/score.txt");
        // Debug.Log("Test！");
        //一行読み込み
        string TotalScore = sr.ReadToEnd();
        //テキストデータ内の　/　が区切り 3000/100/30000
        string[] splitted = TotalScore.Split('/');
        //お金
        string score = splitted[0];
        money.text = score;
            //体力
        string hp = splitted[1];
        life.text = hp;
        //トータルスコア
        string tScore = splitted[2];
        ts.text = tScore;
    }
        void Update()
    {

            //合計得点（リザルト時の得点）体力　*　スコア　=　トータルスコア
           TotalScore = hp * score;
           scoretxt.text = "" + TotalScore;

        }
    
}

