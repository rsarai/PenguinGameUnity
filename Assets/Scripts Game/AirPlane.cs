using UnityEngine;
using System.Collections;

public class AirPlane : MonoBehaviour {
	public float speed;
	public Transform distanceA;
	public Transform distanceB;
	public float timeShoot;
	public GameObject prefab;

	private float currentTimeShot;
	private GameController gmc;
	private bool isPlayer;


	// Use this for initialization
	void Start () {
		gmc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		if (gmc.getCurrentState () == StateMachine.INGAME) {
			Movimento ();
			Raycast ();
		}
	}


	private void Movimento(){
		currentTimeShot += Time.deltaTime;

		if (transform.position.x < 7.9) {
			transform.Translate (speed * Time.deltaTime, 0, 0);
		} else {
			Destroy (gameObject);
		}
	}


	private void Raycast(){
		Debug.DrawLine (distanceB.position, distanceA.position, Color.red);
		isPlayer = Physics2D.Linecast(distanceB.position, distanceA.position, 1<< LayerMask.NameToLayer("Personagem"));

		if (isPlayer && currentTimeShot > timeShoot) {
			currentTimeShot = 0;
			Instantiate (prefab, transform.position, transform.rotation);
		}
	}



}
