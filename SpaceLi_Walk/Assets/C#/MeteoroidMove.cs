using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroidMove : MonoBehaviour
{
    public GameObject Meteoroid;

    private void Update()
    {
        transform.Translate(new Vector3(0.024f, 0f, 0f));
    }
}
