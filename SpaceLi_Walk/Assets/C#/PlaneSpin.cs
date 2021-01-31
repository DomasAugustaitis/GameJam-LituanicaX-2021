using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0.01f, 0f));
    }
}
