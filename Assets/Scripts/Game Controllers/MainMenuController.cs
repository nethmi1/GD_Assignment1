using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public GameObject quitPanel;

	// Use this for initialization
	void Start () {
		if(GameController.instance && MusicController.instance){
			if (GameController.instance.isMusicOn) {
				MusicController.instance.PlayBackgroundSound ();	
			} else {
				MusicController.instance.StopAllSound ();
			}
		}
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			if (!quitPanel.activeInHierarchy) {
				quitPanel.SetActive (true);
			} else {
				quitPanel.SetActive (false);
			}
		}
	}

	public void StartButton(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void YesButton(){
		Application.Quit ();
	}

	public void NoButton(){
		if (quitPanel.activeInHierarchy) {
			quitPanel.SetActive (false);
		}
	}
}
