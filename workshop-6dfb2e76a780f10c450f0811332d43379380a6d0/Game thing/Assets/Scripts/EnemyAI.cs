using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public GameObject player;
	public int badhealth;
	public bool alive;
	public float moveSpeed;

	// Update is called once per frame
	void FixedUpdate () {
		if (alive) {
			transform.position = Vector3.MoveTowards (transform.position, player.transform.position, moveSpeed);
		}
	}
	void OnTriggerEnter(Collider a){
		if (a.gameObject.tag == "9mm") {
			badhealth -= 10;
			if (badhealth <= 0) {
				alive = false;
			}
		}
	}
} 
