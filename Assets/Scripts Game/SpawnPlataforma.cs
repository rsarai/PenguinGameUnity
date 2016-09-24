using UnityEngine;
using System.Collections;

public class SpawnPlataforma : MonoBehaviour {
	private int controle;
	private int gerar;
	private GameController gc;
	private float x;
	private float[] posicoes;


	[Header("Objetos a serem instanciados")][Space(5)]
	public GameObject[] prefabsObs;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameController)) as GameController;
		gerar = Random.Range (1, 4);
		posicoes = new float[gerar];
	}
	
	// Update is called once per frame
	void Update () {
		
		if (gc.getCurrentState () == StateMachine.INGAME) {
			if (controle < gerar) {
				Spawn ();
			} 
		}
	}

	private void Spawn(){
		x = Random.Range (-5f,6f);
		float min, max;
		bool colocar = true;

		if (gerar != 1) {
			for (int i = 0; i < posicoes.Length; i++) {
				min = posicoes [i] - (2.5f	/ 2);
				max = posicoes [i] + (2.5f	/ 2);

				if (x < min || x > max) {
					colocar = true;
				} else {
					colocar = false;
					break;
				}
			}

			if (colocar == true) {
				Instantiate (prefabsObs [0], new Vector3 (x, transform.position.y, transform.position.z), Quaternion.identity);
				posicoes [controle] = x;
				controle++;
			}
		} else {
			Instantiate (prefabsObs [1], new Vector3 (x, transform.position.y, transform.position.z), Quaternion.identity);
			posicoes [controle] = x;
			controle++;
		}
	}







}
