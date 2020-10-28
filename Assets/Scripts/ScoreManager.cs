using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
using UnityEngine.UI;  // 追加しましょう
 
public class ScoreManager : MonoBehaviour {
 
 
    public GameObject score_object = null; // Textオブジェクト
    public static float score_num = 0f; // スコア変数 
    public static float ball_num = 3f; // ボール変数 
    public static int finish_flag = 0; // 終了判定 
  	public GameObject ScoreBoard;
    public RectTransform text_pos;
    public GameObject star_object = null; // Textオブジェクト
    

      // 初期化
    void Start () {
    }
 
    void Update () {
    // オブジェクトからTextコンポーネントを取得
    Text score_text = score_object.GetComponent<Text> ();
    // テキストの表示を入れ替える
    if(finish_flag==0){
      score_text.text = "Score : " + score_num + "\nBall : " + ball_num;
    }
    if(ball_num==0f){
    // テキストの表示を入れ替える
      finish_flag=1;
    }
    if(Input.GetMouseButtonDown(1)){
      ScoreBoard.SetActive (true);    
      score_text.text =  "Score : " + score_num;
      text_pos.position = new Vector3(0f,0f,0f);
      Text star_text = star_object.GetComponent<Text> ();

      if(0<=score_num  && score_num<=10000f){
        star_text.text = "☆☆☆\n\nMiss";
      }
      if(10000<score_num  && score_num<=20000){
        star_text.text = "★☆☆\n\nClear";
      }
      if(20000<score_num && score_num<=30000){
        star_text.text = "★★☆\n\nClear";
      }
      if(30000<score_num && score_num<=40000){
        star_text.text = "★★★\n\nClear";
      }
    }
  }
}