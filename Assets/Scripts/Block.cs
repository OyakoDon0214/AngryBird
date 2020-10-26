using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    float press = 0;

    public GameObject score300;
    public GameObject score100;
    public GameObject score50;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "block"|collision.gameObject.tag =="ball") {
            Vector3 v = collision.rigidbody.velocity;// - GetComponent<Rigidbody> ().velocity;
            float p = Mathf.Sqrt (v.x * v.x + v.y * v.y);
            press +=  p;
            Debug.Log("press"+press);
            
        }
         if(1<press && press<5){
            ScoreManager.score_num += 50f;
            GameObject scoreNumberCopy = Instantiate(score50) as GameObject;
            scoreNumberCopy.transform.position = this.transform.position;
            GameObject.Destroy (scoreNumberCopy,1.5f);
        }
        if(5<press && press<10.0){
            ScoreManager.score_num += 100f;
            GameObject scoreNumberCopy = Instantiate(score100) as GameObject;
            scoreNumberCopy.transform.position = this.transform.position;
            GameObject.Destroy (scoreNumberCopy,1.5f);
        }
        if (press > 10.0) {
            //スコア処理を追加
//            FindObjectOfType<Score>().AddPoint(10);
//            ball.score += 100;
            ScoreManager.score_num += 300f;
            //スコアの数字を表示
            GameObject scoreNumberCopy = Instantiate(score300) as GameObject;
            scoreNumberCopy.transform.position = this.transform.position;
            GameObject.Destroy (scoreNumberCopy,1.5f);
            GameObject.Destroy (gameObject);
            
        }
    }
}
