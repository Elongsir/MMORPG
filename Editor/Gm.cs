using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class Gm
{
    [MenuItem("GMTest/���������˺�")]
    public static void CreatTestUser()
    {
        User testuser = new User()
        {
            UserName = "test",
            Password = "test",
            Uid = "test",
        };
        LocalData.Instance.AddUser(testuser);
    }

    [MenuItem("GMTest/��ȡData")]
    public static void LoadData()
    {
        LocalData.Instance.LoadData();
    }
    [MenuItem("GMTest/����Data")]
    public static void SaveData()
    {
        LocalData.Instance.SaveData();
    }

}
