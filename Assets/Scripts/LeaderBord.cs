﻿using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class LeaderBord : MonoBehaviour
{
    #region PUBLIC_VAR
    public string leaderboard;
    public static string ld;
    bool islogin;
    #endregion
  //  #region DEFAULT_UNITY_CALLBACKS
    void Start()
    {
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;

        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();

        LogIn();
    }

   // #endregion
   // #region BUTTON_CALLBACKS
    /// <summary>
    /// Login In Into Your Google+ Account
    /// </summary>
    public void LogIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("Login Sucess");
                //islogin = !true;
            }
            else
            {
               // islogin = !false;
                Debug.Log("Login failed ");

            }
            islogin = success;
        });
        
    }
    /// <summary>
    /// Shows All Available Leaderborad
    /// </summary>
    public void OnShowLeaderBoard()
    {
        if (!islogin) { LogIn(); OnShowLeaderBoard(); }
        //        Social.ShowLeaderboardUI (); // Show all leaderboard
        ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(ld); // Show current (Active) leaderboard
    }
    /// <summary>
    /// Adds Score To leader board
    /// </summary>
    public static void OnAddScoreToLeaderBorad()
    {
        if (Social.localUser.authenticated)
        {
            Social.ReportScore(GameObject.Find("Scripts").GetComponent<Main>().Score, ld, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Score Success");

                }
                else
                {
                    Debug.Log("Update Score Fail");
                }
            });
        }
    }
    /// <summary>
    /// On Logout of your Google+ Account
    /// </summary>
    public void OnLogOut()
    {
        ((PlayGamesPlatform)Social.Active).SignOut();
    }
   // #endregion

}
