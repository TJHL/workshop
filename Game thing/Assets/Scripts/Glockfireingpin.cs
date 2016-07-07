using UnityEngine;
using System.Collections;

public class Glockfireingpin : MonoBehaviour {

	public GameObject bullet;

	void Update(){
		//Creates a bullet the the desired key is pressed. 
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Instantiate (bullet, transform.position, bullet.transform.rotation);
		}
	}
}
