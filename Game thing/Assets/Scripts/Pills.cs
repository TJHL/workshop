 using UnityEngine;
using System.Collections;

public class Pills : MonoBehaviour {
	public float speed;
	void FixedUpdate () {
		gameObject.transform.Rotate (Vector3.forward*speed);
	}
}
