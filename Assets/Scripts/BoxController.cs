using UnityEngine;
using UnityEngine.SceneManagement;
public class BoxController : MonoBehaviour
{
    public float SceneLength;

    private float speed = 100f;

    public float gravity;

    public GameObject box;

    void Update()
    {
        //Draw a ling to show how wide our scene is.
        Debug.DrawLine(new Vector2(0f, SceneLength), new Vector2(0f, SceneLength));

        //Create a new Vector2 and set it to where the box should move.
        // 'transform' refers the transform component of the gameobject this script is attached to (Box).

        Vector2 newPosition = new Vector2(transform.position.x, transform.position.y + .15f);
        
        //Check if the box is outside the scene.
        if (newPosition.y >= SceneLength)
        {
            speed = -0.5f; //Move left.
            newPosition = new Vector2(transform.position.x, -15f);
        }
        else if (newPosition.y <= SceneLength)
        {
            speed = 0.5f; //Move right.
            

        }

        //Set the transforms position variable to equal our Vector2.

        transform.position = newPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.collider.GetComponent<spikeScript>())
        {
            SceneManager.LoadScene(0);
        }


    }
}
