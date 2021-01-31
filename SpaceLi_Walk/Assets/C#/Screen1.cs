using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Screen1 : MonoBehaviour
{
    public void GoBackToScreen1()
    {
        SceneManager.LoadScene("Screen1");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Screen2");
    }
    public void GoToMain()
    {
        SceneManager.LoadScene("Screen2");
    }
    public void GoToRoutes()
    {
        SceneManager.LoadScene("Screen3");
    }
    public void GoToShop()
    {
        SceneManager.LoadScene("Screen4");
    }
    public void GoToRouteStart()
    {
        SceneManager.LoadScene("Screen5");
    }
    public void GoToAchievements()
    {
        SceneManager.LoadScene("Screen6");
    }
    public void GoToWalk15()
    {
        SceneManager.LoadScene("Walk15");
    }
}
