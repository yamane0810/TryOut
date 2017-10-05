//////////////////////
//製作者　名越大樹
//製作日　10月2日
//クラス名　あたり判定の処理をするクラス　
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField]
    ScoreWrite scoreWriteScript;
    [SerializeField]
    UIManager UIScript;
    [SerializeField]
    Nagoshi.InstanceManager InstanceScript;
    [SerializeField]
    Yamaji.UI UI;
    float cnt = 0.0f;
    /// <summary>
    /// プレイやーがほかのオブジェクト衝突した時の処理
    /// </summary>
    public void HitPlayer(GameObject playerobj, GameObject hitobj)
    {
        //イベントのオブジェクトに衝突した時
        if (hitobj.tag == "Event")
        {
            playerobj.GetComponent<Nagoshi.PlayerStatus>().SetEventObj(hitobj);
            GameObject obj = InstanceScript.InstanceObjects(0, hitobj.transform.position + Vector3.up * 2);
            Destroy(obj, 3.0f);
        }
        //宝に衝突した時
        else if (hitobj.tag == "Tresure")
        {
            int money = playerobj.GetComponent<Nagoshi.PlayerStatus>().GetMoney();
            money += 500;
            playerobj.GetComponent<Nagoshi.PlayerStatus>().SetMoney(money);
            Debug.Log(money);
            Destroy(hitobj);
            GetComponent<SEManager>().PlaySe(3);

        }
        //ギミックに衝突した時
        else if (hitobj.tag == "Gimmick")
        {
            int hp = playerobj.GetComponent<Nagoshi.PlayerStatus>().GetHp();
            hp -= 20;
            playerobj.GetComponent<Nagoshi.PlayerStatus>().SetHp(hp);
        }
        //敵と衝突した時
        else if (hitobj.tag == "Enemy")
        {
            int hp = playerobj.GetComponent<Nagoshi.PlayerStatus>().GetHp();
            hp -= 30;
            playerobj.GetComponent<Nagoshi.PlayerStatus>().SetHp(hp);
            Destroy(hitobj);
        }

        //ゴールオブジェクトに衝突した時
        else if (hitobj.tag == "Goal")
        {
            //スコアの合計の計算開始
            int hp = playerobj.GetComponent<Nagoshi.PlayerStatus>().GetHp();
            int money = playerobj.GetComponent<Nagoshi.PlayerStatus>().GetMoney();
            int sum = hp * money;
            //スコアの合計の計算終了
            string data = money.ToString() + "/" + hp.ToString() + "/" + sum.ToString();
            scoreWriteScript.WirteScore(data);
            SceneManager.LoadScene("ResultScene");
        }

        //地面と接した時
        else if (hitobj.tag == "Ground")
        {
            playerobj.GetComponent<Nagoshi.PlayerStatus>().SetIsJump(true);
        }

        //ゴンドラと接した時
        else if (hitobj.tag == "Gondola")
        {
            //Vector3 copyscale = playerobj.transform.localScale;
            //playerobj.transform.parent = hitobj.transform;
            //playerobj.transform.localScale = copyscale;
            //GetComponent<SEManager>().PlaySe(2);
        }
    }

    /// <summary>
    /// プレイやーがオブジェクトから離れた時
    /// </summary>
    public void ExitPlayer(GameObject playerobj, GameObject exitobj)
    {
        if (exitobj.gameObject.tag == "Fook")
        {
            playerobj.transform.parent = null;
        }
    }

    /// <summary>
    /// プレイやーがトリガーに当たったら
    /// </summary>
    public void HitCollision(GameObject playerobj, GameObject hitobj)
    {
        if (hitobj.gameObject.tag == "Ground")
        {
            playerobj.GetComponent<Nagoshi.PlayerStatus>().SetIsJump(true);
        }

        else if (hitobj.gameObject.tag == "Fook")
        {
            playerobj.transform.parent = hitobj.transform;
        }

    }

    /// <summary>
    /// プレイやーがオブジェクトから離れたら
    /// </summary>
    public void ExitCollsion(GameObject playerobj, GameObject exitobj)
    {
        if (exitobj.gameObject.tag == "Fook")
        {
            playerobj.transform.parent = null;
        }

    }
    public void StayCollision(GameObject playerobj, GameObject stayObj)
    {
        //毒エリアに衝突した時
        if (stayObj.tag == "Smog")
        {
            cnt += Time.deltaTime;
            int hp = playerobj.GetComponent<Nagoshi.PlayerStatus>().GetHp();
            if (cnt > 1.0f)
            {
                hp -= 5;
                cnt = 0.0f;
            }
            playerobj.GetComponent<Nagoshi.PlayerStatus>().SetHp(hp);
        }
    }
}