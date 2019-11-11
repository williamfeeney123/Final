using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to add this for access to the SceneManagment class.


public class collisionTester : MonoBehaviour
{
    public GameObject spikes;
    public GameObject spike;
    public GameObject trap;
    public GameObject spikeTrap;
    public GameObject win;
    public GameObject win2;
    public GameObject finalWin;
    public GameObject begin;
    public GameObject win3;



    //Any Collider2D component will call this function on
    //any attached scripts when the collider enters a collision with another collider.
    //The gameobject must also have a RigidBody2D attached.
    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.collider.gameObject == spikes)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
        if (collision.collider.gameObject == spike)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }

        if (collision.collider.gameObject == trap)
        {
            GameObject newBall = Instantiate(spikeTrap, new Vector3(4, 10, 0f), Quaternion.Euler(new Vector3(0,0,180f)));
            GameObject newBall2 = Instantiate(spikeTrap, new Vector3(186, 20, 0f), Quaternion.Euler(new Vector3(0, 0, 180f)));

        }
        if (collision.collider.GetComponent <spikeScript> ())
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }


      

        if (collision.collider.gameObject == begin)
        {
            SceneManager.LoadScene(1);
        }
          if (collision.collider.gameObject == win)
        {
            SceneManager.LoadScene(2);
        }

        if (collision.collider.gameObject == win2)
        {
            SceneManager.LoadScene(3);
        }

        if (collision.collider.gameObject == win3)
        {
            SceneManager.LoadScene(4);
        }

        if (collision.collider.gameObject == finalWin)
        {
            SceneManager.LoadScene(5);
        }
    }


}


