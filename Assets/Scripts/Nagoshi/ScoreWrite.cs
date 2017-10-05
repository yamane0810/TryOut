////////////////////////////
//製作者　名越大樹
//製作日　10月4日
//スコアを書き込むクラス
////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
public class ScoreWrite : MonoBehaviour {


    public void WirteScore(string data)
    {
        StreamWriter sr = new StreamWriter(Application.dataPath + "/Resources/score.txt");
        sr.Write(data);
        sr.Close();
    }
}
