//////////////////////////////////////
//制作　山根良太
//日付　10月3日
//内容　ゲームオーバーシーン
//////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverScene : MonoBehaviour
{
    void Update()
    {
        GameOver();
    }
    public void GameOver()
    {
        
        if (Input.anyKeyDown)
        {
            //タイトルシーンへ移行
            SceneManager.LoadScene("TitleScene");
        }
    }
}
