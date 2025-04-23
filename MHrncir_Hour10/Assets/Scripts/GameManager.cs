using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    public ChaosGoalScript chaos;
    private bool isGameOver = false;

    private void StartGame()
    {
        isGameOver = false;

        // Any other game start logic can go here
    }
    void Update ()
    {
            // Check if all goals are solved
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;

    }
    void OnGUI()
        {
        if(isGameOver)
            {
                Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
                GUI.Box (rect, "Game Over");
                Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
                GUI.Label (rect2, "Good Job!");
            }
        }
}