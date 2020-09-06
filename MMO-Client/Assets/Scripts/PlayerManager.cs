using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int id;
    public string username;
    public Renderer model;
    [SerializeField]
    Color color;

    public void SetColor(Color color)
    {
        this.color = color;
        model.material.color = color;
    }
    public void SendDripToServer()
    {
        ClientSend.PlayerDrip(color);
    }
}
