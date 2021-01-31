using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUp : MonoBehaviour
{
    public void ToPuzzle()
    {
        SceneManager.LoadScene("Puzzle1");
    }
}
