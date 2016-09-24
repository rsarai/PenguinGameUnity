using UnityEngine;
using System.Collections;

public class ExitScene : MonoBehaviour { 
	//private GameObject player;
	//private Vector3 posStart;
	private GameController gc;

	// Use this for initialization
	void Start () {
		//player = GameObject.FindWithTag ("Player");
		//posStart = player.transform.position;
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Problema
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("Game Over");
			gc.setCurrentState (StateMachine.GAMEOVER);
		}
	}

}
