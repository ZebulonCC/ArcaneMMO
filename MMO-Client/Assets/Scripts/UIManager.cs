using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject startMenu;
    public InputField usernameField;
    public Color playerColor;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        startMenu.SetActive(false);
        usernameField.interactable = false;
        Client.instance.ConnectToServer();
    }

    public void SetColorRed()
    {
        playerColor = Color.red;
    }
    public void SetColorBlue()
    {
        playerColor = Color.blue;
    }
    public void SetColorGreen()
    {
        playerColor = Color.green;
    }
    public void SetColorYellow()
    {
        playerColor = Color.yellow;
    }
    public void SetColor(Vector4 color)
    {

    }
}
