using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
public class LevelSwicher : MonoBehaviour {
	public string nextlevel;
	void Update () {
		if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			SceneManager.LoadScene (nextlevel);
		}
	}
}