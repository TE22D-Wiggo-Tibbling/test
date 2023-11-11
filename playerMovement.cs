using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{

    [SerializeField]
    float speed = 3;

 



  

    

    [SerializeField] 
    float health = 3.0f;

      [SerializeField]
    Transform slag;

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");

        Vector2 movementX = new Vector2(moveX, 0);


        transform.Translate(movementX * speed * Time.deltaTime);


    }


  private void OnTriggerEnter2D(Collider2D other) {
             if (other.gameObject.tag == "enemy")
        {
            health--;
            if(health<1){
                  Destroy(this.gameObject);
            }
        }
       
        }



    // void OnDrawGizmos()
    // {
    //     // ____________________________________________________________________________________________
    //     // -----------------------------------hop Gizmo------------------------------------------------
    //     // ____________________________________________________________________________________________

    //     Gizmos.color = Color.green;
    //     Vector3 size = MakeGroundcheckSize();
    //     Gizmos.DrawWireCube(groundCheck.position, size);

    //     // ____________________________________________________________________________________________
    //     // -----------------------------------slå Gizmo------------------------------------------------
    //     // ____________________________________________________________________________________________

    //      Gizmos.DrawWireCube(slag.position, size);
         
        

    // }



}
