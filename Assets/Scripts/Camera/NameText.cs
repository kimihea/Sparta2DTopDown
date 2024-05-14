using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class NameText : MonoBehaviour
{
    public GameObject Canvas;
    public Text playerName;
    private void Update()
    {
        Vector2 Canvaspos = Camera.main.WorldToScreenPoint(new Vector2(transform.position.x, transform.position.y));
        Canvas.transform.position = Canvaspos;
    }
    private void Start()
    {
        string playername = PlayerPrefs.GetString("PlayerName");
        playerName.text = playername;
    }

}