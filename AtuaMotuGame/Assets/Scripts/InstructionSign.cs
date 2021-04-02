﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionSign : Interactable
{
    // Start is called before the first frame update

    public GameObject dialogBoxPrefab;
    public GameObject dialogBox;
    public bool isActive = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            // Check if the dialogbox is already active, then de-activate
           if (isActive)
            {
                Destroy(dialogBox);
                isActive = false;
            }
          else
            {
                isActive = true;
                dialogBox = Instantiate(dialogBoxPrefab);
            }
        }
    }

      private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            clue.Raise();
            //clueOn.Raise();
        }
    }



}