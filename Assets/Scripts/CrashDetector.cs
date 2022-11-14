using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    public bool isAlive = true;
    private bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //plays crash effect and resets game on player crashing
        if (collision.tag != "Finish Line" && !hasCrashed)
        {
            isAlive = false;
            hasCrashed = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            FindObjectOfType<PlayerController>().surfaceEffector2D.speed = 0;
            Invoke("ReloadScene", reloadDelay);
        }

    }

    // reloads Scene
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("You Finished");
    }
}
