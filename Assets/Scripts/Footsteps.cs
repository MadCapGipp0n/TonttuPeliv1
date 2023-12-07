using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public GameObject footstep;
    public GameObject jumpsound;

    private CapsuleCollider capsuleCollider;

    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;
    float raycastLength = -0.13f;
    int delay = 1000;

    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
        jumpsound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + raycastLength, whatIsGround);
     
        if (Input.GetKey("w") & grounded)
        {
            footsteps();
        }
        if (Input.GetKey("s") & grounded)
        {
            footsteps();
        }
        if (Input.GetKey("a") & grounded)
        {
            footsteps();
        }
        if (Input.GetKey("d") & grounded)
        {
            footsteps();
        }

        if (Input.GetKeyUp("w") || !grounded)
        {
            StopFootsteps();
        }
        if (Input.GetKeyUp("s") || !grounded)
        {
            StopFootsteps();
        }
        if (Input.GetKeyUp("a") || !grounded)
        {
            StopFootsteps();
        }
        if (Input.GetKeyUp("d") || !grounded)
        {
            StopFootsteps();
        }


        

    }
    void footsteps()
    {
        footstep.SetActive(true);
    }
    void StopFootsteps()
    {
        footstep.SetActive(false);
    }
    void jumpsounds()
    {
        jumpsound.SetActive(true);
    }
    void StopJumpsounds()
    {
        jumpsound.SetActive(false);
    }
}
