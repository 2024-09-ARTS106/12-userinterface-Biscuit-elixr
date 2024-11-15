using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    public Animator dialog;

    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
    }

    // Start is called before the first frame update
    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }
}
