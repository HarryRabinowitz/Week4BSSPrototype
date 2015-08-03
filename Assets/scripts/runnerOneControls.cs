using UnityEngine;
using System.Collections;

public class runnerOneControls : MonoBehaviour {


	public float speed = 1000f;

	public float rotationSpeed = 100f;

	//Used Speed + Drag
	//Mass 0.5f, Drag 1f, Speed 1000f


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		//Controls for running player 1
		float runnerOneX = Input.GetAxis ("runnerOneHorizontal") * rotationSpeed * Time.deltaTime;
		float runnerOneZ = Input.GetAxis ("runnerOneVertical") * speed * Time.deltaTime;
		
		
		Rigidbody rbody = GetComponent<Rigidbody> ();

		//Controls for moving left and right instead of turning left and right
	//rbody.AddForce (runnerOneX, 0f, 0f); 
	//rbody.AddForce (0f, 0f, runnerOneZ);

		//Turning
		rbody.transform.Rotate (0f, runnerOneX, 0f);
		//Acceleration
		rbody.AddRelativeForce (0f, 0f, runnerOneZ);

	}
}
