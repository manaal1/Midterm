using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {

	//Set from Unity
	[SerializeField]
	float speed = 5f;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform = null;
	private Vector2 _currentPosition ;

	//Constants
	private const float startPos = 312f;
	private const float resetPos = -184f;

	// Use this for initialization
	void Start () {
	
		_transform = gameObject.transform;
		_currentPosition = _transform.position;

		//Reset the position
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {

		//TODO: Your implementation of the scrolling backgriund


		if (gameObject.transform.position.x < resetPos)
			Reset ();
	}

	public void Reset(){
	
		//TODO: Reset backgorund


	}


}
