using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Screen5Text : MonoBehaviour
{
    public TextMeshProUGUI distancetext;
    public TextMeshProUGUI ratingtext;
    // Start is called before the first frame update
    void Start()
    {
        distancetext.GetComponent<TextMeshPro>();
        ratingtext.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        distancetext.text = "Distance - " + Routes.distance + "km";
        ratingtext.text = "Rating - " + Routes.review + "/10";
    }
}
