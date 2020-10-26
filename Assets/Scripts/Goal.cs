using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    float press = 0;
    public GameObject score5000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
//  コメント追加
    void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "block"|collision.gameObject.tag =="ball") {
            Vector3 v = collision.rigidbody.velocity;// - GetComponent<Rigidbody> ().velocity;
            float p = Mathf.Sqrt (v.x * v.x + v.y * v.y);
            press +=  p;
        }
        if (press > 10.0) {
            //スコア処理を追加
//            FindObjectOfType<Score>().AddPoint(10);
//            ball.score += 100;
            ScoreManager.score_num += 5000f;
            //スコアの数字を表示
            GameObject scoreNumberCopy = Instantiate(score5000) as GameObject;
            scoreNumberCopy.transform.position = this.transform.position;
            GameObject.Destroy (gameObject);
            GameObject.Destroy (scoreNumberCopy,1.5f);

            
        }
    }
}