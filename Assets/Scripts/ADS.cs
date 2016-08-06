﻿using UnityEngine;
using System.Collections;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;
using System;

public class ADS : MonoBehaviour, IInterstitialAdListener
{
    static string appKey = "9fec31db4775c144bfa9af550e65b5bceb26ab23c12f2d84";
    public bool Banner, Reward, Video, Interst;
    int ite;
    // Use this for initialization

    void Start () {
        if (Banner) ShowBanner();
        if (Reward) ShowReward();
        if (Video && ite == 3) //заменить на dontdestroyonload
        {
            loop(); ShowVideo();
            DontDestroyOnLoad(this);
        }
        if (Interst) ShowInterstitial();

    }

    // Update is called once per frame
    void Update () {
	
	}
    void loop()
    {
        if (ite == 3) ite = 0;
        ite += 1;
    }

    public static void ShowBanner()
    {
        Appodeal.initialize(appKey, Appodeal.BANNER);
        Appodeal.show(Appodeal.BANNER);

    }

    public static void ShowReward()
    {
        Appodeal.initialize(appKey, Appodeal.REWARDED_VIDEO);
        Appodeal.show(Appodeal.REWARDED_VIDEO);
    }

    public static void ShowVideo()
    {
        Appodeal.initialize(appKey, Appodeal.NON_SKIPPABLE_VIDEO);
        Appodeal.show(Appodeal.NON_SKIPPABLE_VIDEO);
    }

    public static void ShowInterstitial()
    {
        Appodeal.initialize(appKey, Appodeal.INTERSTITIAL);
        Appodeal.show(Appodeal.INTERSTITIAL);
    }

    #region Interstitial callback handlers
    public void onInterstitialLoaded() { print("Interstitial loaded"); }
    public void onInterstitialFailedToLoad() { print("Interstitial failed"); }
    public void onInterstitialShown() { print("Interstitial opened"); }
    public void onInterstitialClosed() { print("Interstitial closed"); }
    public void onInterstitialClicked() { print("Interstitial clicked"); }
    #endregion
}
