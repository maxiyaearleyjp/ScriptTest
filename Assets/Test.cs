using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//配列を初期化
		int[] array = {30, 20, 10, 1, 25};

		// 配列を順番に表示
		Debug.Log("1:" + array[0]);	
		Debug.Log("2:" + array[1]);	
		Debug.Log("3:" + array[2]);	
		Debug.Log("4:" + array[3]);	
		Debug.Log("5:" + array[4]);	
			
		// 配列を逆順に表示
		for (int i = array.Length - 1; i >= 0; i--) {
			Debug.Log(i + ":" + array[i]);
		}

		// Bossクラスのインスタンス生成
		Boss boss = new Boss ();

		// 魔法攻撃10回
		for (int i = 0; i < 10; i++) {
			boss.Magic ();
		}

		// MPが足りない
		boss.Magic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53;          // 魔法力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	// 魔法用の関数
	public  void Magic() {

		if (this.mp < 5) {
			Debug.Log("MPが足りないため魔法が使えない。");
		}
		else {
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
		}
	}
}