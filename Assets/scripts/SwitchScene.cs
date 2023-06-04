using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string sceneName;

    public void NextScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GoBack()
    {
        int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        int currentSceneName = SceneManager.GetActiveScene().buildName;
        switch(currentSceneName){
            case "KingScene":
            case "KnightScene":
            case "PawnScene":
                SceneManagement.LoadScene("ChessPedia");
            break;
            case "A":
            case "B":
            case "C":
            case "D":
                SceneManager.LoadScene("ABCBook");
            break;
            case "ChessPedia":
                SceneManagement.LoadScene("AR Book");
            break;
            case "ABCBook":
                SceneManager.LoadScene("AR Pedia");
            break;
            case "AR Book":
            case: "AR Pedia":
                SceneManager.LoadScene("Home");
            break;
            case "Home":
                Application.Quit();
                break;
            default:
                Application.Quit();
        }
    } 
    void Update()
    {
    if (Application.platform == RuntimePlatform.Android) {
        
        if (Input.GetKeyDown(KeyCode.Escape)) {
            GoBack();
        }
        }
    }
}
