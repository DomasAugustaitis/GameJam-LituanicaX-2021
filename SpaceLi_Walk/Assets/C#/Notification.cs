using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class Notification : MonoBehaviour
{
    void Start()
    {
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }
    
    public void SendNotification(string notificationText)
    {
        var notification = new AndroidNotification();
        notification.Title = "Puzzle Detected";
        notification.Text = notificationText;
        notification.FireTime = System.DateTime.Now;
        notification.SmallIcon = "icon_small";
        notification.LargeIcon = "icon_large";

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }

    
}
