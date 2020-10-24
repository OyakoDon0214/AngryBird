using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
using UnityEngine.UI;  // 追加しましょう
 
public class ScoreManager : MonoBehaviour {
 
 
    public GameObject score_object = null; // Textオブジェクト
    public static float score_num = 0f; // スコア変数 
    public static float ball_num = 3f; // ボール変数 
    

      // 初期化
    void Start () {
    }
 
    void Update () {
    // オブジェクトからTextコンポーネントを取得
    Text score_text = score_object.GetComponent<Text> ();
    // テキストの表示を入れ替える
    score_text.text = "Score : " + score_num + "\nBall : " + ball_num;
 
    }
}