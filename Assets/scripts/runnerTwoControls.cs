using UnityEngine;
using System.Collections;

public class runnerTwoControls : MonoBehaviour {


	public float speed = 1000f;

	public float rotationSpeed = 100f;
	//Optimal Speed + Drag
	//Mass 0.5f, Drag 1f, Speed 1000f
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//Controls for running player 2
		float runnerTwoX = Input.GetAxis ("runnerTwoHorizontal") * rotationSpeed * Time.deltaTime;
		float runnerTwoZ = Input.GetAxis ("runnerTwoVertical") * speed * Time.deltaTime;
		
		
		Rigidbody rbody = GetComponent<Rigidbody> ();
	
		//Controls for moving left and right instead of turning left and right
	//	rbody.AddForce (runnerTwoX, 0f, 0f); 
	//	rbody.AddForce (0f, 0f, runnerTwoZ);
	
		//Turning
		rbody.transform.Rotate (0f, runnerTwoX, 0f);
		//Accelation
		rbody.AddRelativeForce (0f, 0f, runnerTwoZ);
		
	}
}
