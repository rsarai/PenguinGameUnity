using UnityEngine;
using System.Collections;

public class AviaoFlag : MonoBehaviour {
	private int tempo;
	private float currentTime;
	private GameController gmc;

	public GameObject prefab;

	// Use this for initialization
	void Start () {
		gmc = FindObjectOfType (typeof(GameController)) as GameController;
		tempo = Random.Range (10, 20);
	}
	
	// Update is called once per frame
	void Update () {
		if (gmc.getCurrentState () == StateMachine.INGAME) {
			if (tempo > currentTime) {
				currentTime += Time.deltaTime;
			} else {
				Instantiate (prefab, transform.position, Quaternion.identity);
				currentTime = 0;
			}

		}
	}
}
