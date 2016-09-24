using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	private GameController gameC;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameC = FindObjectOfType (typeof(GameController)) as GameController;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.layer == 9 || other.gameObject.layer == 10) {
			Destroy (gameObject);
		}

		if (other.gameObject.tag == "Player") {
			Destroy (gameObject);
			gameC.setCurrentState (StateMachine.GAMEOVER);

		}
	}
}


