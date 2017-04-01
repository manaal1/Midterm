using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	[SerializeField]
	private float speed=1;

	private Transform _transform = null;

	//Constants
	private const float top = 122;
	private const float bottom = -119;

	// Use this for initialization
	void Start () {
	
		_transform = gameObject.transform;
	}
	

	void FixedUpdate () {

		Vector2 currentPosition = gameObject.transform.position;

		//TODO: Read Input and move the player object

		//TODO Add bounds on top and bottom


		_transform.position = currentPosition;

	
	}
}
