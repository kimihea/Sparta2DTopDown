using UnityEngine.SceneManagement;
using UnityEngine;

public class EnterHouseScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("HouseScene");
    }
}