using UnityEngine;
using System.Collections;

public class SpawnNuvem : MonoBehaviour {

	private GameController gc;
	private float currentTimeToSpawn;


	[Header("Tempo maximo para instanciar")][Space(5)]
	public float timeToSpawn;
	[Header("Objetos a serem instanciados")][Space(5)]
	public GameObject[] prefabsObs;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameController)) as GameController;
		currentTimeToSpawn = timeToSpawn;

	}
	
	// Update is called once per frame
	void Update () {
		if (gc.getCurrentState () == StateMachine.INGAME) {
			currentTimeToSpawn += Time.deltaTime;
			if (currentTimeToSpawn >= timeToSpawn) {
				Spawn ();
				currentTimeToSpawn = 0;
			}
		}
	}

	private void Spawn(){
		int i = Random.Range (0, prefabsObs.Length);
		int y = Random.Range (-3, 5);

		
		Instantiate (prefabsObs [i], new Vector3(-8,transform.position.y + y, transform.position.z), Quaternion.identity);
	}
}
