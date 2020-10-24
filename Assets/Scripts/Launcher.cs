using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    //ballプレハブ
    public GameObject ball;
    //弾が生成されるポジションを保有するゲームオブジェクト
    public GameObject ballPos;

    Vector3 forceDirection;

    Vector3 force;

     // 上の向きに加わる力の大きさを定義
    [SerializeField]
    public float forceMagnitude = 10.0f;

    // X軸からの角度
    [SerializeField]
    public float forceX= 1.0f;
    public float forceY= 1.0f;

    GameObject unitychan; 
    VNectModel VNectModel; //Scriptが入る変数
    void Start()
    {
        //外部スクリプトを取得する処理
        unitychan = GameObject.Find ("unitychan");
        VNectModel = unitychan.GetComponent<VNectModel>(); 
    }
    // Update is called once per frame
    void Update()
    {
        //スペースが押されたとき
        if (Input.GetKeyDown(KeyCode.Space))
        {

            forceDirection = new Vector3(forceX, forceY, 0);
            Vector3 force=forceDirection*forceMagnitude;
            shoot(force);
       }
        //マウスがクリックされたとき
        if(Input.GetMouseButtonDown(0)){
            var rHand=VNectModel.JointPoints[PositionIndex.rHand.Int()];
            var lHand=VNectModel.JointPoints[PositionIndex.lHand.Int()];
            Vector3 force=lHand.Pos3D-rHand.Pos3D;
            force.z=0;
            force/=20;
            Debug.Log("force"+force);
            shoot(force);
        }
    }
    public void shoot(Vector3 force){
        //ballをインスタンス化して発射
        GameObject createdBall = Instantiate(ball) as GameObject;
        createdBall.transform.position = ballPos.transform.position;

        //.ボールの個数-1
        ScoreManager.ball_num --;
        // // 入力された角度をラジアンに変換
        // float rad = forceAngle * Mathf.Deg2Rad;

        // // それぞれの軸の成分を計算
        // float x = Mathf.Cos(rad);
        // float y = Mathf.Sin(rad);
        // float z = 0.0f;

        // // Vector3型に格納
        // forceDirection = new Vector3(x, y, z);

        // // 向きと大きさからSphereに加わる力を計算する
        // force = forceMagnitude * forceDirection;

        // Rigidbodyに力を加えて発射
        createdBall.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);

    }

}