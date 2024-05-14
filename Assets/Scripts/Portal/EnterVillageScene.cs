using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterVilliageScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("VillageScene");
    }
}