using UnityEngine;
using System.Collections;

public class CameraTeste : MonoBehaviour {
	private Vector2 speed;
	private float smooth = 0.5f;
	private GameObject  player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Pinguin");
		speed = new Vector2 (0.5f, 0.5f);
	}

	// Update is called once per frame
	void Update () {
		Follow ();
	}

	private void Follow(){
		if(player.transform.position.y/2 > transform.position.y/2){
			Vector2 positionCamera = Vector2.zero;
			positionCamera.y = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref speed.y, smooth);
			Vector3 newPosition = new Vector3 (transform.position.x, positionCamera.y, transform.position.z);
			//lerp, calcular a distancia entre os objetos e a rota
			transform.position = Vector3.Lerp(transform.position, newPosition, Time.time);
		}
	}
}
