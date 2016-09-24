using UnityEngine;
using System.Collections;

public class PinguimMovimento : MonoBehaviour {
	private GameController gameC;
	private Rigidbody2D rb;

	public Transform ground;
	public bool isground;
	public float force;
	public float speed;
	[Header("Selecione a Layer do Chão")][Space(5)]
	public LayerMask qualLayer;

	// Use this for initialization
	void Start () {
		gameC = FindObjectOfType (typeof(GameController)) as GameController;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameC.getCurrentState () == StateMachine.INGAME) {
			Movimento ();		
		}
	}


	private void Movimento(){
		Walk ();
		Jump ();
	}

	private void Walk(){
		if (Input.GetAxisRaw ("Horizontal") > 0) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
		}
	}

	private void Jump(){
		isground = Physics2D.OverlapCircle (ground.position, 0.02f, qualLayer);

		if (isground && Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector2 (0, force));
			isground = !isground;
		} else {
			isground = !isground;
		}

	}


}
