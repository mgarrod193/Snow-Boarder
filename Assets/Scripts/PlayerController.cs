using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D playerRb;

    [SerializeField] float torqueAmount = 1;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
}
