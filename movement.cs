using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public GameObject character;

    public Text dialogueText;
    public Text dialogueText2;

    private float sidespeed = 12f;
    public float speed = 14f;
    private float gravity = -9.81f;
    private float jumpHeight = 4f;
    private float distanceRan;

    private int score;

    public double crouch;

   
    public Transform groundCheck;
    private float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    private bool isGrounded;

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {      
        //score mechanic
        distanceRan = character.transform.position.z;
        score = (int)distanceRan;
        dialogueText.text = "Score:" + score * 2;
        dialogueText2.text = "Total Score:" + score * 2;

        //game speed increases the more you play
        if (score > 350 && speed < 15)
        {
            speed = speed + 1;
        }
        else if (score > 750 && speed < 16)
        {
            speed = speed + 1;
        }

        //Movement mechanics. The left and right movement is controllable, while the forward movement is automatic.
        float x = Input.GetAxis("Horizontal");
        float z = 1f;

        
        
        Vector3 sidemove = transform.right * x ;
        Vector3 forwardmove = transform.forward * z;



        controller.Move(sidemove * sidespeed * Time.deltaTime);
        controller.Move(forwardmove * speed * Time.deltaTime);


        //jumping mechanic
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
            

        }


        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        //crouching mechanic, also can be used to speed up the fall, while in the air. 
        //That is on purpose, it gives the player more agility.
        if (Input.GetButton("Crouch"))
        {
            transform.localScale = new Vector3(1f, 0.25f, 1f);
            gravity = -20f;
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            gravity = -9.81f;
        }

        //cheks if the player is on the ground so he can jump again
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }

       

        /* to do
         * Generate terrain mechanic (done)
         * Add score (done)
         * Add some UI (done)
         * Increase speed while game progresses (but maybe set a cap) (done)
         * Add an end game screen (done)
         * Make a main menu (done)
         */
    }
}
