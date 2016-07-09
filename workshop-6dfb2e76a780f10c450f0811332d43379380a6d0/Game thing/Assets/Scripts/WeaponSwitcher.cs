using UnityEngine;
using System.Collections;

public class WeaponSwitcher : MonoBehaviour {
	public GameObject ShotGun;
	public GameObject Glock;
	// Use this for initialization
	void Start () {
		ShotGun.GetComponent<MeshRenderer> ().enabled = false;
		for (int a = 0; a < ShotGun.transform.childCount; a++) {
			ShotGun.transform.GetChild (a).GetComponent<MeshRenderer> ().enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Glock.GetComponent<MeshRenderer> ().enabled = false;
			ShotGun.GetComponent<MeshRenderer> ().enabled = true;
		}
	}
}
