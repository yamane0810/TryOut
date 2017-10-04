//////////////////////////////////////
//制作　山根良太
//日付　10月4日
//内容　リザルトシーン
//////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResultScene : MonoBehaviour
{
    void Update()
    {
        Result();
    }
    public void Result()
    {

        if (Input.anyKeyDown)
        {
            //タイトルシーンへ移行
            SceneManager.LoadScene("TitleScene");
        }
    }
}
