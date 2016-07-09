using UnityEngine;
using System.Collections;

public class FireingPIn : MonoBehaviour {

	public GameObject bullet;

	void Update(){
		//Creates a bullet the the desired key is pressed. 
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			GameObject round = (GameObject)Instantiate (bullet, transform.position, gameObject.transform.rotation);
			round.transform.Rotate (90, 0, 0);
		}
	}
}
