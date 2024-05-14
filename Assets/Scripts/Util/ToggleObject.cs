using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject targetObject; // 토글할 대상 오브젝트
    public GameObject character1;
    public GameObject character2;

    public void ToggleActive()
    {
        // 대상 오브젝트의 활성 여부를 반전시킵니다.
        targetObject.SetActive(!targetObject.activeSelf);
    }
    public void ToggleCharacter1()
    {
        character1.SetActive(!character1.activeSelf);
    }
    public void ToggleCharacter2()
    {
        character2.SetActive(!character2.activeSelf);
    }
}