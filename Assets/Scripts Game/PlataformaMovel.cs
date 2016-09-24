using UnityEngine;
using System.Collections;

public class PlataformaMovel : MonoBehaviour {
	private GameController gc;

	public float speed;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		if (gc.getCurrentState () == StateMachine.INGAME) {
			Movimento ();
			if (transform.position.x > 5.0f) {
				speed = speed * -1;
			} else if (transform.position.x < -4.0f) {
				speed = speed * -1;
			}
		}
	}

	void Movimento(){
		transform.Translate (speed * Time.deltaTime, 0,0);
	}



}
