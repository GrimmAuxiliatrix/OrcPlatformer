using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public Canvas MainCanvas;
	public Canvas HowToCanvas;

	void Awake() {
		HowToCanvas.enabled = false;
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
		SceneManager.LoadScene("scene", LoadSceneMode.Additive);
	}
}
