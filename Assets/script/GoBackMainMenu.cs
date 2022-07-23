using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackMainMenu : MonoBehaviour
{
    public void goBackbutton()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Quitbutton()
    {
        Application.Quit();
    }

    public void Level1Button()
    {
        SceneManager.LoadScene(2);
    }

    public void Level2button()
    {
        SceneManager.LoadScene(3);
    }

}
