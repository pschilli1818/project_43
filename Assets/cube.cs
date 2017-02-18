using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        //print(Input.GetAxis("HorizontalUI"));
        
        transform.Translate(0f, Input.GetAxis("VerticalUI") * Time.deltaTime, 0f);

    }
}
