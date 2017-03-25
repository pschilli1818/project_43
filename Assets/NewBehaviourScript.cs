using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//print ("yo im a cube for real");
	}
	
	// Update is called once per frame
	void Update () 
	{


		transform.Translate(0f,Input.GetAxis("VerticalUI")* Time.deltaTime,0f);
	}
}
