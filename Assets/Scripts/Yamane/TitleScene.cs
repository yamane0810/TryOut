//////////////////////////////////////
//制作　山根良太
//日付　10月3日
//内容　タイトルシーン
//////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    void Update()
    {
        Title();
    }
    public void Title()
    {
        //何かキー（ボタン）が押された時ゲームシーンへ移動
        if (Input.anyKeyDown)
        {
            //Debug.Log("Start");
            //ゲームシーンへ移行
            SceneManager.LoadScene("nago");
        }
    }
}
