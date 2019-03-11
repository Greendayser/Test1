using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characbehavior : MonoBehaviour {
    
    public RigidBody2D rb;
    public float vitesse;
	// Use this for initialization
	void Start () {
        rb.velocity += new vector2(vitesse, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
