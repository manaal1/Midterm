using UnityEngine;
using System.Collections;

public class GemController : MonoBehaviour {

	[SerializeField]
	private Vector2 speed = new Vector2 (5, 1);

	private Vector2 _currentPosition;
	private Transform _transform = null;

	//Constants

	private const float topPosition = 155;
	private const float resetYPosition = -155;
	private const float resetXPosition = -210;

	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPosition = _transform.position;
	}

	// Update is called once per frame
	void Update () {

		_currentPosition = _transform.position;
		_currentPosition -= speed;
		_transform.position = _currentPosition;
		if (_transform.position.x < -resetXPosition || _transform.position.y<resetYPosition) {

			Reset ();

		}


	}

	public void Reset(){
		//Random speed, do not change this line
		speed = new Vector2 (3, Random.Range (1, 5));

		//TODO reset the position of the gem to appear above the camera and to have x between 0 and 180

	}

	//TODO: select appropriate function based on the collider type used in Unity

	public void OnCollisionEnter2D(Collision2D other){
		//Implement collision here
	}

	public void OnTriggerEnter2D(Collider2D other){
		//Implement collision here
	}

}
