using UnityEngine;
using System.Collections;

public class PlataformaCollider : MonoBehaviour {
	 
	private GameController gc;

	private GameObject chaoPinguin;




	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameController)) as GameController;
		chaoPinguin = GameObject.FindWithTag ("Limite");
	}
	
	// Update is called once per frame
	void Update () {
		if (gc.getCurrentState () == StateMachine.INGAME) {

			if (transform.position.y >= chaoPinguin.transform.position.y) {
				gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			}
			if(transform.position.y < chaoPinguin.transform.position.y){
				gameObject.GetComponent<BoxCollider2D> ().enabled = true;

			}
		}
	}



}
