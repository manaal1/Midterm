using UnityEngine;
using System.Collections;

public class Player {

	public HUDController _hud = null;

	private static Player _instance = null;

	public static Player Instance{
		get{
			if (_instance == null) {
				_instance = new Player ();
			}
			return _instance;
		}
	}

	private int _points = 0;

	public int Points {
		get{ 
			return _points;
		}
		set{ 
			_points = value;
		}
	}

	private int _lives = 0;

	public int Lives {
		get{ 
			return _lives;
		}
		set{ 
			_lives = value;
			if (_lives <= 0) {
				_hud.endGame ();
			}
		}
	}


	private Player(){
	
	}
}
