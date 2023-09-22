using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishThe : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            CompleteLevel();
        }

    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(0);
    }
}
