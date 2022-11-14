using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D playerRb;

    [SerializeField] float boostSpeed = 30;
    [SerializeField] float baseSpeed = 20;

    private CrashDetector crashDetectorScript;
    public SurfaceEffector2D surfaceEffector2D;

    [SerializeField] float torqueAmount = 1;
    // Start is called before the first frame update
    void Start()
    {
        crashDetectorScript = GetComponent<CrashDetector>();
        playerRb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (crashDetectorScript.isAlive)
        {
            rotatePlayer();
            respondToBoost();
        }
    }

    void rotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddTorque(-torqueAmount);
        }
    }


    //if we push speed up player
    void respondToBoost()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
