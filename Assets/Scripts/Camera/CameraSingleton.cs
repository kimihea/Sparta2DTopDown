using UnityEngine;

public class CameraSingleton : MonoBehaviour
{
    private static CameraSingleton instance;
    private Camera mainCamera;
    public static Camera GetMainCamera
    {
        get{ return instance.mainCamera; }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            mainCamera = Camera.main;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static CameraSingleton GetInstance()
    {
        return instance;
    }

    
}