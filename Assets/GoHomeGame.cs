using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

	public Vector2 playerLocation;
	public Vector2 homeLocation;
	bool gameIsOver = false;

	// Use this for initialization
	void Start () {
		print("Welcome to Go Home!");
		print("A game were you need to find you way back.");
	}

	// Update is called once per frame
	void Update () {
		if(!gameIsOver) {
		updateMovement (KeyCode.LeftArrow, new Vector2 (-1, 0));
		updateMovement (KeyCode.RightArrow, new Vector2 (1, 0));
		updateMovement (KeyCode.UpArrow, new Vector2 (0, 1));
		updateMovement (KeyCode.DownArrow, new Vector2 (0, -1));
			}
	}
	private void updateMovement(KeyCode kc, Vector2 movementVector)
	{
		if (Input.GetKeyDown (kc)) {
			playerLocation = playerLocation + movementVector;
			PrintDistanceToHome ();
		}
	}

	private void PrintDistanceToHome() {
			Vector2 pathToHome = homeLocation - playerLocation;
			print("Distance to home: " + pathToHome.magnitude);
			if (playerLocation == homeLocation)
			{
				print("I am at home!");
			gameIsOver = true;
			}
		}
}