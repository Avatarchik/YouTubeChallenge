using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel () {
        SceneManager.LoadScene("SecondScreen");
	}
}
