﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    private bool entered; //If the mouse is currently pointing at this object

    private void Start()
    {
        entered = false;
    }

    // Update is called once per frame
    private void Update () {
		
        // See if we've entered the object and if we're pressing the left mouse button
        if (entered && Input.GetButtonDown("Fire1") )
        {
            interact();
        }
	}

    // Virtual method for interaction, overriden in children 
    public virtual void interact()
    {}

    // Set 'entered' 
    protected virtual void OnMouseEnter()
    {
        entered = true;
    }
    protected virtual void OnMouseExit()
    {
        entered = false;
    }
}
