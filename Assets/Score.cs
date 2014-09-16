using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

		// スコア
		private int score;

		// スコアを初期化する
		void InitScore() {
				this.score = 0;
		}

		// スコアを加算する
		void AddScore(int score) {
				this.score += score;
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				// GUIテキストを書き換える
				guiText.text = "Score:" + this.score;
	}
}
