using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to add this for access to the SceneManagment class.

public class levelChange : MonoBehaviour
{
    public void GotoLevel(int level)
    {
        Debug.Log("Loading scene " + level);
        SceneManager.LoadScene(level);
    }
}