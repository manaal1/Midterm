using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text pointsLabel = null;

	[SerializeField]
	Text livesLabel = null;


	//TODO: Add missing references to other UI elements and GameObjects

	//TODO: make sure that Player class has reference to the HUDController

	void initialize(){
	
		//TODO:Complete the function. Make sure that everything is displayed/hidden as per spec

	}

	void Start(){
		initialize ();
	}

	public void updateDisplay(){
	
		//TODO: add code to update Labels 
		// 		make sure that this function is called when Player class (points/lives) is updated

	}

	public void endGame(){
		//Your code to show GameOver and score and disable player/enemy/gems
	}

	public void RestartButtonClick(){
	
		//Your code to reset the the HUD here 
		Debug.Log("Button click");
		
	}
}
