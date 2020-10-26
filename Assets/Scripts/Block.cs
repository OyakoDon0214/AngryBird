using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    float press = 0;

    public GameObject scoreNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (press > 10.0) {
            //スコア処理を追加
//            FindObjectOfType<Score>().AddPoint(10);
//            ball.score += 100;
            ScoreManager.score_num += 100f;
            //スコアの数字を表示
            //スコアの数字を表示
            GameObject scoreNumberCopy = Instantiate(scoreNumber) as GameObject;
            scoreNumberCopy.transform.position = this.transform.position;
            GameObject.Destroy (scoreNumberCopy,1.5f);
            GameObject.Destroy (gameObject);
            
        }
    }
    void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "block"|collision.gameObject.tag =="ball") {
            Vector3 v = collision.rigidbody.velocity;// - GetComponent<Rigidbody> ().velocity;
            float p = Mathf.Sqrt (v.x * v.x + v.y * v.y);
            press +=  p;
            Debug.Log("press"+press);
            
        }
    }
}
