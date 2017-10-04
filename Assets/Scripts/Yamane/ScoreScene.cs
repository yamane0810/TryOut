//////////////////////////////////////
//制作　山根良太
//日付　10月3日
//内容　スコアシーン
//////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreScene : MonoBehaviour
{
	void Update ()
    {
        Score();
	}
    public void Score()
    {
        if (Input.anyKeyDown)
        {
            //タイトルシーンへ移行
            SceneManager.LoadScene("TitleScene");
        }
    }
}
