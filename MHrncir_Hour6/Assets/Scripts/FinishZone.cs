using UnityEngine;

public class FinishZone : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager;
	
	// When an object enters the finish zone, let the
	// game manager know that the current game has ended
	void OnTriggerEnter(Collider other)
	{
		gameManager.FinishedGame();
	}
}
