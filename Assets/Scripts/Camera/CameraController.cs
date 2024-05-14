using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    private Transform playerTransform;
    public Vector3 offset;

    void LateUpdate()
    {
        playerTransform = PlayerSingleTon.GetTransform;
        if (playerTransform != null)
        {
            Vector3 desiredPosition = playerTransform.position + offset;
            // 카메라의 Z 축을 유지하여 2D 화면을 유지합니다.
            desiredPosition.z = transform.position.z;
            transform.position = desiredPosition;
        }
    }
}