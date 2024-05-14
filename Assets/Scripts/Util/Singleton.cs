using UnityEngine;

public class PlayerSingleTon : MonoBehaviour
{
    public static PlayerSingleTon Instance { get; private set; }
    private Transform playerTransform;
    public static Transform GetTransform
    {
        get { return Instance.playerTransform; }
    }
    private PlayerSingleTon() { }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            playerTransform = transform;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static PlayerSingleTon GetInstance()
    {
        return Instance;
    }
}