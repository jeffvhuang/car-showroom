﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    //public static string currentSelectedCar = "myLamboConvert";
    public static string currentSelectedCar = "myPorsche";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }

    public void ChangeLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
