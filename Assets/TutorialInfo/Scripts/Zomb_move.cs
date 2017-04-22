using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zomb_move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("HorizontalUI") * Time.deltaTime, 0f, Input.GetAxis("VerticalUI") * Time.deltaTime);
	}
}
