using UnityEngine;
using System.Collections;

public class DestruirCenario : MonoBehaviour {
	private GameObject player;
	private GameController gc;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		if (gc.getCurrentState () == StateMachine.INGAME) {
			if ((transform.position.y + 7.0f) < player.transform.position.y)
				Destroy (gameObject);
		}
	}
}
