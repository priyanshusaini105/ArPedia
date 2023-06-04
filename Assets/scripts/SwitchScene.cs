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
        if(previousSceneIndex >= 0)
        SceneManager.LoadScene(previousSceneIndex);
        else
        Application.Quit();
    } 
    void Update()
    {
    // Make sure user is on Android platform
    if (Application.platform == RuntimePlatform.Android) {
        
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
            // Quit the application
            GoBack();
        }
    }
}
}
