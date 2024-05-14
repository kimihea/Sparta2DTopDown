using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneController : MonoBehaviour
{
    public InputField inputField;
    public Button joinButton;
    public string mainSceneName;

    private void Start()
    {
        joinButton.onClick.AddListener(OnStartButtonClick);
    }

    private void OnStartButtonClick()
    {
        string playerName = inputField.text;
        if (!string.IsNullOrEmpty(inputField.text)&&(playerName.Length>=2&& playerName.Length <= 10))
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            PlayerPrefs.Save();
            SceneManager.LoadScene(mainSceneName);
        }
        else
        {
            // 입력된 값이 없다면, 사용자에게 메시지를 표시할 수 있습니다.
            Debug.Log("Input field is empty! Please enter a value.");
        }
    }
}