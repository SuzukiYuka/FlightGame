using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, 0, -10.0f * Time.deltaTime);
	}
}
