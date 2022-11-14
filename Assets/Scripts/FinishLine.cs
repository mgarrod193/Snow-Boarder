using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float reloadDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;


    //Method called when collision with trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //reloads game on completion and plays effect
        if (collision.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadDelay);
        }
    }


    // Resets Scene
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("You Finished");
    }
}
