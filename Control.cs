using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    float ctrlspeed = 3f;
    public GameObject pad1;
    public GameObject pad2;

	void Start () {
		
	}
	
	
	void Update () {
        
       
        if (Input.GetKey(KeyCode.W))
        {
            pad1.transform.Translate(new Vector3(0, ctrlspeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            pad1.transform.Translate(new Vector3(0, -ctrlspeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.I))
        {
            pad2.transform.Translate(new Vector3(0, ctrlspeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K))
        {
            pad2.transform.Translate(new Vector3(0, -ctrlspeed, 0) * Time.deltaTime);
        }
    }
}
