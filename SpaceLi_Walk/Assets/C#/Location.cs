using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public static Location Instance { set; get; }

    public static float latitude;
    public static float longitude;
    public float StationLocationLongitude = 25215614;
    public float StationLocationLatitude = 54764113;
    public float LocatioCheckLongitude;
    public float LocatioCheckLatitude;
    public float LocationControllLongitude;
    public float LocationControllLatitude;
    public bool IsAtLocation = false;


    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
        InvokeRepeating("Repeat", 2, 2);
    }

    void Repeat()
    {
        StartCoroutine(StartLocationService());

    }
    private IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("User has not enabled GPS");
            yield break;
        }

        Input.location.Start();
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        if (maxWait <= 0)
        {
            Debug.Log("Timed out");
            yield break;
        }

        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determin device location");
        }

        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;

        yield break;
    }

    private void Update()
    {
        LocatioCheckLongitude = longitude*1000000 - StationLocationLongitude;
        LocatioCheckLatitude = latitude*1000000 - StationLocationLatitude;

        if (LocatioCheckLatitude < 0)
        {
            LocationControllLatitude = LocatioCheckLatitude * -1;
        }
        if (LocatioCheckLongitude < 0)
        {
            LocationControllLongitude = LocatioCheckLongitude * -1;
        }
        if (LocationControllLatitude <=5 && LocationControllLongitude <= 5)
        {
            IsAtLocation = true;
        }
    }
}
