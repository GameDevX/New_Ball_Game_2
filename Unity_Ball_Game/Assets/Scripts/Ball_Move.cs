using UnityEngine;
using System.Collections;

public class Ball_Move : MonoBehaviour {

    bool isContact;
    Rigidbody Ball_rb;

    

	// Use this for initialization
	void Start () {

        Ball_rb = gameObject.GetComponent<Rigidbody>();
     
	}
	
	// Update is called once per frame
	void Update () {

	}

    void FixedUpdate()
    {
        

        Ball_Movement(10);
        Ball_Jump(500);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isContact = true;
            
        }
      
    }


    void Ball_Jump(float Jump_Speed)
    {
        if (isContact)
        {
            Ball_rb.AddForce(new Vector3(0, Jump_Speed));
            isContact = false;
        }
    }
    
    void Ball_Movement(float speed)
    {
       
        float Move_Horizontal;
        Move_Horizontal = Input.GetAxis("Horizontal");
        Ball_rb.AddForce(new Vector3(Move_Horizontal * speed, 0, 0));
    }

    

}
