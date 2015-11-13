using UnityEngine;
using System.Collections;

public class Respawner : MonoBehaviour {

	public float deathY;
	public float respwanDrop;

	private float initialX;
	private float initialY;

	// Use this for initialization
	void Start () {
		initialX = transform.position.x;
		initialY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < deathY) {
			transform.position = new Vector3(initialX, initialY + respwanDrop, transform.position.z);
		}
	}
}
