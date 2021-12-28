using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Classes;

public class UIActions : MonoBehaviour
{
    //private User user;

    public void LogIn()//string email, string password)
    {
        
    }

    public void LogOut()
    {
        //user = null;
        SceneManager.LoadScene(0);
    }
}
