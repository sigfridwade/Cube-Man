using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	public Rigidbody rb;

	// Update is called once per frame
	void Update () {
		
		rb.AddForce(0, 0, 200);

	}

}
