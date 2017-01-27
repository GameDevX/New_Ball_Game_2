using UnityEngine;
using System.Collections;

public class Cam_Follow : MonoBehaviour {

   
    public Transform Target;
    
    Vector3 offset = new Vector3(0, 0, -10);
	void Start () {
       
    }
	
	// Update is called once per frame
	void LateUpdate () {

        Vector3 desiredPosition = new Vector3(Target.transform.position.x,0,0) + offset;
        transform.position = desiredPosition;
	
	}
}
