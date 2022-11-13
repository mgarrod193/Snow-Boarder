using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 2f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Finish Line")
        {
            Invoke("ReloadScene", reloadDelay);
        }

    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("You Finished");
    }
}
