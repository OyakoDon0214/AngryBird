using UnityEngine;
using System.Collections;

public class FallBlock : MonoBehaviour {

	// 変数の定義（データを入れる箱を作る）
	private Rigidbody rb;

	void Start(){

		// 代入（箱の中にデータを入れる）
		rb = GetComponent<Rigidbody>();
	}
		
	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Player")){

			// （ポイント）Invoke("呼び出すメソッド名", 呼び出すまでの時間)
			// Fallという名前のメソッドを２秒後に呼び出す。
			Invoke("Fall", 2);
		}
	}

	void Fall(){

		// （ポイント）isKinematicを無効化する
		rb.isKinematic = false;
	}
}
