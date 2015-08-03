using UnityEngine;
using System.Collections;

public class ballerCamera : MonoBehaviour {


	public GameObject ballCamera;

	public Vector3 ballCameraCoordinates;

	public float ballCameraYCompensator;
	public float ballCameraZCompensator;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		ballCameraCoordinates = GameObject.FindWithTag ("baller").GetComponent<ballerControls> ().transform.position;
	


		//Places the camera position to the same position as the baller
		//Then, the ballCameraCompensators adjust the camera so it is slighly behind and above the ball instead of inside it
		ballCamera.transform.position = new Vector3 (
			(GameObject.FindWithTag ("baller").GetComponent<ballerControls> ().transform.position.x), 
			(GameObject.FindWithTag ("baller").GetComponent<ballerControls> ().transform.position.y + ballCameraYCompensator),
			(GameObject.FindWithTag ("baller").GetComponent<ballerControls> ().transform.position.z - ballCameraZCompensator)
			);



	}
}
