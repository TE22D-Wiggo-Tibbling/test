using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{

    [SerializeField]
    float jumpforce = 100;

       [SerializeField]
    Transform groundCheck;

      [SerializeField]
    float groundRadius = 0.4f;

      [SerializeField]
    LayerMask groundLayer;

    bool mayJump = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                // bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
        Vector3 size = MakeGroundcheckSize();
        bool isGrounded = Physics2D.OverlapBox(groundCheck.position, size, 0,groundLayer);


        if (Input.GetAxisRaw("Jump") > 0 && mayJump == true && isGrounded == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector2 jump = Vector2.up * jumpforce;

            rb.AddForce(jump);

            mayJump = false;
        }


        if (Input.GetAxisRaw("Jump") == 0)
        {
            mayJump = true;
        }

      
    }

     private Vector3 MakeGroundcheckSize() => new Vector3(100.0f 100.0f);
}
