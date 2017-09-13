using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemyScript : MonoBehaviour {
	float speed = 1f;
	// Use this for initialization
	void Start () {
		speed = Random.Range (-10.0f, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, speed));
		Debug.Log (speed);
	}
}
