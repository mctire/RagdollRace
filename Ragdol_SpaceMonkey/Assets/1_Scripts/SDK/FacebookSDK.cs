using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Facebook.Unity;

public class FacebookSDK : MonoBehaviour
{
    /*
    void Awake()
    {
        if (!FB.IsInitialized)
        {
            // Initialize the Facebook SDK
            FB.Init(InitCallback, OnHideUnity);
        }
        else
        {
            // Already initialized, signal an app activation App Event
            FB.ActivateApp();
        }
            DontDestroyOnLoad(this);
    }

    private void Start()
    {
        LevelController.levelStartEvent.AddListener(StartLevel);
        LevelController.levelWinEvent.AddListener(EndLevel);
        LevelController.levelFailEvent.AddListener(FailLevel);
    }

    private void InitCallback()
    {
        if (FB.IsInitialized)
        {
            // Signal an app activation App Event
            FB.ActivateApp();
            // Continue with Facebook SDK
            // ...
        }
        else
        {
            Debug.Log("Failed to Initialize the Facebook SDK");
        }
    }

    private void OnHideUnity(bool isGameShown)
    {
        if (!isGameShown)
        {
            // Pause the game - we will need to hide
            Time.timeScale = 0;
        }
        else
        {
            // Resume the game - we're getting focus again
            Time.timeScale = 1;
        }
    }

    public static void StartLevel(int levelNum, string sceneName)
    {
        var tutParams = new Dictionary<string, object>();
        tutParams["Level_number"] = levelNum.ToString();
        tutParams["Scene_name"] = sceneName;

        FB.LogAppEvent("Level start", parameters: tutParams);
    }

    public static void EndLevel(int levelNum, string sceneName)
    {
        var tutParams = new Dictionary<string, object>();
        tutParams["Level_number"] = levelNum.ToString();
        tutParams["Scene_name"] = sceneName;

        FB.LogAppEvent("Level complete", parameters: tutParams);
    }

    public static void FailLevel(int levelNum, string sceneName)
    {
        var tutParams = new Dictionary<string, object>();
        tutParams["Level_number"] = levelNum.ToString();
        tutParams["Scene_name"] = sceneName;

        FB.LogAppEvent("Level fail", parameters: tutParams);
    }
    */
}
