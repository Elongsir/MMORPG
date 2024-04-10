using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class Gm
{
    [MenuItem("GMTest/创建测试账号")]
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

    [MenuItem("GMTest/读取Data")]
    public static void LoadData()
    {
        LocalData.Instance.LoadData();
    }
    [MenuItem("GMTest/保存Data")]
    public static void SaveData()
    {
        LocalData.Instance.SaveData();
    }

}
