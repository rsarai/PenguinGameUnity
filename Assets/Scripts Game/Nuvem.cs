using UnityEngine;
using System.Collections;

public class Nuvem : MonoBehaviour {
	private float speed;
	public GameObject gc;
	private GameController gmc;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameObject)) as GameObject;
		gmc = FindObjectOfType (typeof(GameController)) as GameController;
		speed = Random.Range (0.0f, 2.0f);
	}

	// Update is called once per frame
	void Update () {

		if (gmc.getCurrentState () == StateMachine.INGAME) {
			if (transform.position.x < 7.9) {
				transform.Translate (speed * Time.deltaTime, 0, 0);
			} else {
				Destroy (gameObject);
			}
		}
	}
}
