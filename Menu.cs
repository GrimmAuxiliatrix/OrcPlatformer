using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public Canvas MainCanvas;
	public Canvas HowToCanvas;
	public Canvas WinCanvas;

	void Awake() {
		HowToCanvas.enabled = false;
		WinCanvas.enabled = false;

		if (SceneManager.sceneCount >= 2) {
			SceneManager.UnloadSceneAsync ("scene");
			MainCanvas.enabled = false;
			WinCanvas.enabled = true;
		}
	}

	public void HowToOn() {
		HowToCanvas.enabled = true;
		MainCanvas.enabled = false;
	}

	public void ReturnOn() {
		HowToCanvas.enabled = false;
		MainCanvas.enabled = true;
	}
	public void LoadOn() {
		SceneManager.LoadScene("scene", LoadSceneMode.Single);
		//MainCanvas.enabled = false;
	}

	public void QuitOn(){
		Application.Quit();
	}

}
