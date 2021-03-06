﻿using UnityEngine;

public class PushingBehaviour : MonoBehaviour
{
    public Vector3 forceVector = new Vector3(0f, 0f, 10f);
    public ForceMode forceMode = ForceMode.Impulse;

    Rigidbody rigidBody;

    void Start()
    {
		rigidBody = GetComponent<Rigidbody>();
	}

    // Handling physics should be done in FixedUpdate, not in Update
    void FixedUpdate()
	{
        if(Input.GetButton("Jump"))
        {
            rigidBody.AddForce(forceVector, forceMode);
        }
    }
}
