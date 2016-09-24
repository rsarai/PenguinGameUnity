using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ControllerGameOver : MonoBehaviour {
	public Text bestScore;
	public Text score;

	// Use this for initialization
	void Start () {
		bestScore.text = PlayerPrefs.GetInt ("bestScore").ToString();
		score.text = PlayerPrefs.GetInt ("score").ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Menu() {
		SceneManager.LoadScene ("Menu");
	}

	public void ReturnGame(){
		SceneManager.LoadScene ("Game");
	}
		
}
