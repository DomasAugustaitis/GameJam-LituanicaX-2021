using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MeteoroidPuzzle : MonoBehaviour
{
    public GameObject meteoroid1;
    public GameObject meteoroid2;
    public GameObject meteoroid3;
    public GameObject meteoroid4;
    public GameObject meteoroid5;
    public GameObject meteoroid6;
    public GameObject meteoroid1UI;
    public GameObject meteoroid2UI;
    public GameObject meteoroid3UI;
    public GameObject meteoroid4UI;
    public GameObject meteoroid5UI;
    public GameObject meteoroid6UI;
    public GameObject GetReadyUI;
    public GameObject NonMeteoroid;
    public GameObject ScoreText;
    public GameObject VictoryText;
    public Text score;
    public Transform NotMeteoroid;
    public static bool correctAnswer;
    private float randomNum;
    private float points = 5;
    private void Start()
    {
        InvokeRepeating("Meteoroid", 6, 6);
        score.text = points.ToString();
    }
    void Meteoroid()
    {
        if(correctAnswer == false)
        {
            points += 1;
        }
        correctAnswer = false;
        score.text = points.ToString();
        ScoreText.SetActive(true);
        GetReadyUI.SetActive(false);
        randomNum = Random.Range(1, 7);
        NonMeteoroid.transform.position = new Vector3(4.2f, Random.Range(-4f,6f), 4.19f);
        if (randomNum == 1)
        {
            Instantiate(meteoroid1, NotMeteoroid.position, NotMeteoroid.rotation);
            meteoroid1UI.SetActive(false);
            meteoroid2UI.SetActive(true);
            meteoroid3UI.SetActive(false);
            meteoroid4UI.SetActive(false);
            meteoroid5UI.SetActive(false);
            meteoroid6UI.SetActive(false);
        }
        if (randomNum == 2)
        {
            Instantiate(meteoroid2, NotMeteoroid.position, NotMeteoroid.rotation);
            meteoroid1UI.SetActive(false);
            meteoroid2UI.SetActive(false);
            meteoroid3UI.SetActive(true);
            meteoroid4UI.SetActive(false);
            meteoroid5UI.SetActive(false);
            meteoroid6UI.SetActive(false);
        }
        if (randomNum == 3)
        {
            Instantiate(meteoroid3, NotMeteoroid.position, NotMeteoroid.rotation);
            meteoroid1UI.SetActive(true);
            meteoroid2UI.SetActive(false);
            meteoroid3UI.SetActive(false);
            meteoroid4UI.SetActive(false);
            meteoroid5UI.SetActive(false);
            meteoroid6UI.SetActive(false);
        }
        if (randomNum == 4)
        {
            Instantiate(meteoroid4, NotMeteoroid.position, NotMeteoroid.rotation);
            meteoroid1UI.SetActive(false);
            meteoroid2UI.SetActive(false);
            meteoroid3UI.SetActive(false);
            meteoroid4UI.SetActive(true);
            meteoroid5UI.SetActive(false);
            meteoroid6UI.SetActive(false);
        }
        if (randomNum == 5)
        {
            Instantiate(meteoroid5, NotMeteoroid.position, NotMeteoroid.rotation);
            meteoroid1UI.SetActive(false);
            meteoroid2UI.SetActive(false);
            meteoroid3UI.SetActive(false);
            meteoroid4UI.SetActive(false);
            meteoroid5UI.SetActive(true);
            meteoroid6UI.SetActive(false);
        }
        if (randomNum == 6)
        {
            Instantiate(meteoroid6, NotMeteoroid.position, NotMeteoroid.rotation);
            meteoroid1UI.SetActive(false);
            meteoroid2UI.SetActive(false);
            meteoroid3UI.SetActive(false);
            meteoroid4UI.SetActive(false);
            meteoroid5UI.SetActive(false);
            meteoroid6UI.SetActive(true);
        }
    }
    public void correct()
    {
        points -= 1;
        score.text = points.ToString();
        meteoroid1UI.SetActive(false);
        meteoroid2UI.SetActive(false);
        meteoroid3UI.SetActive(false);
        meteoroid4UI.SetActive(false);
        meteoroid5UI.SetActive(false);
        meteoroid6UI.SetActive(false);
        correctAnswer = true;
    }
    public void incorrect()
    {
        score.text = points.ToString();
        meteoroid1UI.SetActive(false);
        meteoroid2UI.SetActive(false);
        meteoroid3UI.SetActive(false);
        meteoroid4UI.SetActive(false);
        meteoroid5UI.SetActive(false);
        meteoroid6UI.SetActive(false);
        correctAnswer = false;
    }
    private void Update()
    {
        if(points == 0)
        {
            VictoryText.SetActive(true);
            Invoke("NextScene", 5f);
        }
    }
    void NextScene()
    {
        SceneManager.LoadScene("Walk15");
    }
}
