﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.GetAxis("HorizontalUI"));

      transform.Translate(Input.GetAxis("HorizontalUI") * Time.deltaTime, 0f, 0f);
    }
}
