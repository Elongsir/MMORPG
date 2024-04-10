using System;
using System.Collections.Generic;
using UnityEngine;

public class LocalData
{
    private static LocalData instance;
    public static  LocalData Instance
    { 
        get 
        { 
            if(instance == null)
            {
                instance = new LocalData();
            }
            return instance; 
        } 
    }
    public  List<User> Users;

    public void AddUser(User user)
    {
        if(this.Users == null) 
        {
            Users = new List<User>();
        }
        this.Users.Add(user);
    }
    public void SaveData()
    {
        string inventoryjson = JsonUtility.ToJson(this);
        PlayerPrefs.SetString("CharaData", inventoryjson);
        PlayerPrefs.Save();
    }

    public List<User> LoadData()
    {
        if(Users!=null)
        {
            return Users;
        }
        if(PlayerPrefs.HasKey("CharaData")) 
        {
            string inventoryJson =PlayerPrefs.GetString("CharaData");
            LocalData localdata= JsonUtility.FromJson<LocalData>(inventoryJson);
            this.Users=localdata.Users;
            return this.Users;
        }
        else
        {
            this.Users = new List<User>();
            return this.Users;
        }
    }
}

[Serializable]
public class User
{
    public string Uid;
    public string UserName;
    public string Password;
    public List<LocalItem> Items;
    public override string ToString()
    {
        return string.Format("[Uid]:{0},[UserName]:{1},[Password]:{2}", Uid, UserName, Password);
    }
}
[Serializable]
public class LocalItem
{
    public string Uid;
    public int id;
    public string Name;
    public int num;
    public override string ToString()
    {
        return string.Format(",[Uid]:{1},[Name]:{2},[Num]:{3}",  Uid, id, Name, num);
    }
}
enum ItemType
{
    Weapon,
    Food,
    Function,
}