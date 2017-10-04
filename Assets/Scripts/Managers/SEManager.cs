///////////////////////
//製作者　名越大樹
//製作日　10月3日
//クラス名　ゲームで使用するSEのマネージャークラス
///////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour {

    [SerializeField]
    AudioClip[] seDatas;
    [SerializeField]
    AudioSource audioSorce;
    public void PlaySe(int number)
    {
        audioSorce.clip = seDatas[number];
        audioSorce.Play();
    }

}
