using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get { 
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance; 
        }
    }
    public List<User> users;
    public User LocalUser;
    public void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        users =LocalData.Instance.LoadData();
        
    }
    public List<User> GetUsers()
    { 
        return users;
    }
    /// <summary>
    /// 账号登录
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="PassWord"></param>
    /// <returns></returns>
    public User VerifyUser(string userName, string PassWord)//账户验证是否存在
    {
        if(GameManager.instance.GetUsers()==null)
        {
            Debug.Log("Users为空");
            return null;
        }
        if(GameManager.instance.GetUsers()!=null)
        {
            foreach ( User user in GameManager.Instance.GetUsers())
            {
                if (user.UserName == userName)
                {
                    if (user.Password == PassWord)
                    {
                        return user;
                    }
                }
            }
            
        }
        return null;

    }
    public bool CreatUser(string username,string passWord)
    {
        if(GameManager.instance.VerifyUser(username,passWord)!=null)
        {
            return false;
        }

        User user = new User()
        {
            Uid = System.Guid.NewGuid().ToString(),
            UserName = username,
            Password = passWord,
            Items = new List<LocalItem>(),
  
        };
        LocalData.Instance.AddUser(user);
        LocalData.Instance.SaveData();
        return true;
    }


}
