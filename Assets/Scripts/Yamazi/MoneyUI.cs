/////////////////
//制作  山路優樹
//日付  10月2日
//説明  所持金UI処理
/////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    int showValue;                              //表示値
    float width;                                //一桁横幅
    public Sprite[] imageNum;                   //各数値画像配列
    [SerializeField]
    GameObject showSprite;                      //画像表示用オブジェ
    GameObject[] numPos;                        //表示用オブジェ配列
    public Dictionary<char, Sprite> sprite;     //ディクショナリ

    void Start()
    {
        sprite = new Dictionary<char, Sprite>()
            {
                { '0', imageNum[0] },
                { '1', imageNum[1] },
                { '2', imageNum[2] },
                { '3', imageNum[3] },
                { '4', imageNum[4] },
                { '5', imageNum[5] },
                { '6', imageNum[6] },
                { '7', imageNum[7] },
                { '8', imageNum[8] },
                { '9', imageNum[9] },
            };
    }

    // 表示する値
    public int Value
    {
        get
        {
            return showValue;
        }
        set
        {
            showValue = value;
            // 表示文字列取得
            string strValue = value.ToString();
            // 現在表示中のオブジェクト削除
            if (numPos != null)
            {
                foreach (GameObject numSprite in numPos)
                {
                    GameObject.Destroy(numSprite);
                }
            }
            // 表示桁数分だけオブジェクト作成
            numPos = new GameObject[strValue.Length];
            for (int i = 0; i < numPos.Length; ++i)
            {
                // オブジェクト作成
                numPos[i] = Instantiate(showSprite, transform.position + new Vector3((float)i * width, 0), Quaternion.identity) as GameObject;
                // 表示する数値指定
                numPos[i].GetComponent<SpriteRenderer>().sprite = sprite[strValue[i]];
                // 自身の子階層に移動
                numPos[i].transform.parent = transform;
            }
        }
    }
}
