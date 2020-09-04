﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void FixedUpdate()
    {
        SendInputToServer();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SendDripToServer();
            Debug.Log("DripSent");
        }
    }

    private void SendInputToServer()
    {
        bool[] _inputs = new bool[]
        {
            Input.GetKey(KeyCode.W),
            Input.GetKey(KeyCode.S),
            Input.GetKey(KeyCode.A),
            Input.GetKey(KeyCode.D),
        };

        ClientSend.PlayerMovement(_inputs);
    }

    public void SendDripToServer()
    {
        ClientSend.PlayerDrip();
    }
}
