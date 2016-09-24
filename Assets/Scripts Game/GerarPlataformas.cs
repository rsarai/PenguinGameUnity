using UnityEngine;
using System.Collections;

public class GerarPlataformas : MonoBehaviour {

	public GameObject prefab;

	private GameController gc;
	private GameObject flag;

	// Use this for initialization
	void Start () {
		flag = GameObject.Find ("Flag");
		gc = FindObjectOfType (typeof(GameController)) as GameController;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			Instantiate (prefab, flag.transform.position, Quaternion.identity);
			gameObject.GetComponent<Collider2D> ().enabled = false;
			flag.transform.position = new Vector3(0, flag.transform.position.y + 8.8f, transform.position.z);
			gc.setScore (50);
		}
	}

}
