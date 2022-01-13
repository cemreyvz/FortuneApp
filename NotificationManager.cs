using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;


public class NotificationManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateNotifChannel();
        SendNotification();
    }
    void CreateNotifChannel()
    { 
    var c = new AndroidNotificationChannel()
    {
        Id = "Notif1",
        Name = "Reminder",
        Importance = Importance.High,
        Description = "Reminds to play",
    };
    AndroidNotificationCenter.RegisterNotificationChannel(c);
}

    void SendNotification()
    {
        var notification = new AndroidNotification();
        notification.Title = "Notif Test";
        notification.Text = "Haydi Bir Niyet Çek";
        notification.FireTime = System.DateTime.Now.AddHours(24);
        notification.LargeIcon = "icon_1";

        AndroidNotificationCenter.SendNotification(notification, "Notif1");
    }

}
