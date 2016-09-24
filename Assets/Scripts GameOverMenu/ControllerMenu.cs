using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ReturnGame(){
		SceneManager.LoadScene ("Game");
	}



}
