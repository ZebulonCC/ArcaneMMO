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
    public Vector4 Color
    {
        get
        {
            return color;
        }
        set
        {
            color = new Color(value.x, value.y, value.z, value.w);
            model.material.color = color;
        }
    }
}
