﻿using UnityEngine;
using System.Collections;
//using AppodealAds.Unity.Api;
//using AppodealAds.Unity.Common;
using System;

public class ADS : MonoBehaviour
{
    string appKey = "b8fdc19744ddd35fa4adc69fa620645d57e6b52959ee3798";
    public bool Banner, Reward, Video, Interst;
    // Use this for initialization

    void Start () {
        //if (Banner) ShowBanner();
        //if (Reward) ShowReward();
        //if (Video) ShowVideo();
        //if (Interst) ShowInterstitial();

    }

    // Update is called once per frame
    void Update () {
	
	}

    //void ShowBanner() {
    //    Appodeal.initialize(appKey, Appodeal.BANNER);
    //    Appodeal.show(Appodeal.BANNER);
    //}

    //void ShowReward() {
    //    Appodeal.initialize(appKey, Appodeal.REWARDED_VIDEO);
    //    Appodeal.show(Appodeal.REWARDED_VIDEO);
    //}

    //void ShowVideo() {
    //    Appodeal.initialize(appKey, Appodeal.NON_SKIPPABLE_VIDEO);
    //    Appodeal.show(Appodeal.NON_SKIPPABLE_VIDEO);
    //}

    //void ShowInterstitial() {
    //    Appodeal.initialize(appKey, Appodeal.INTERSTITIAL);
    //    Appodeal.show(Appodeal.INTERSTITIAL);
    //}
}
