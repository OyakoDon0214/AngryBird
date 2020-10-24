using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    float press = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (press > 20.0) {
            //スコア処理を追加
//            FindObjectOfType<Score>().AddPoint(10);
//            ball.score += 100;
            ScoreManager.score_num += 100f;
            GameObject.Destroy (gameObject);
        }
    }
//  コメント追加
    void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "block") {
            Vector3 v = collision.rigidbody.velocity;// - GetComponent<Rigidbody> ().velocity;
            float p = Mathf.Sqrt (v.x * v.x + v.y * v.y);
            press +=  p;
//            ball.score += p;
//            Debug.Log(collision.rigidbody.velocity);
        }
    }
}