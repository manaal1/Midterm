using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	[SerializeField]
	private float speed = 5f;


	private Vector2 _currentPosition;
	private Transform _transform = null;

	//Constants
	private const float startPosition = 220;
	private const float resetPosition = -220;

	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPosition = _transform.position;
	}
	
	void FixedUpdate () {

		_currentPosition = _transform.position;

		//TODO: move the enemy with the given speed

		_transform.position = _currentPosition;
		if (_transform.position.x < resetPosition) {

			Reset ();

		}

	
	}

	public void Reset(){
		
		//TODO: implement reset for the enemy. It should appear in the random position (vertical) out of the view of the player
	}


	//TODO: select appropriate function based on the collider type used in Unity

	public void OnCollisionEnter2D(Collision2D other){
		//Implement collision here
	}

	public void OnTriggerEnter2D(Collider2D other){
		//Implement collision here
	}

}
