using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ViewModel : MonoBehaviour {
	public void LoadScene(int sceneIndex) {
		 SceneManager.LoadScene(sceneIndex);

	}



}