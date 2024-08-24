
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;

    // The code will be called whenever we will collide with an object
    void OnCollisionEnter(Collision collisionInfo)
    {
        //If we hit an object with the tag object the console should show Object
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // When the player hits an object the movement stops making our game end
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
