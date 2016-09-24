using UnityEngine;
using System.Collections;

public class CameraMovimento : MonoBehaviour {
	public float speed;
	private GameController gameC;

	// Use this for initialization
	void Start () {
		gameC = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameC.getCurrentState () == StateMachine.INGAME) {
			Subir ();
		}
	}

	private void Subir(){
		transform.Translate (0, speed * Time.deltaTime, 0);
	}
}
