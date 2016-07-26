using UnityEngine;
using System.Collections;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class ADS : MonoBehaviour
{
    string appKey = "fee50c333ff3825fd6ad6d38cff78154de3025546d47a84f";
    public bool Banner, Reward, Video, Interst;
    // Use this for initialization
    void Start () {
        Appodeal.initialize(appKey, Appodeal.BANNER);
        Appodeal.show(Appodeal.BANNER);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void ShowBanner() {
        Appodeal.initialize(appKey, Appodeal.BANNER);
        Appodeal.show(Appodeal.BANNER);
    }

    void ShowReward() {
        Appodeal.initialize(appKey, Appodeal.REWARDED_VIDEO);
        Appodeal.show(Appodeal.REWARDED_VIDEO);
    }

    void ShowVideo() {
        Appodeal.initialize(appKey, Appodeal.NON_SKIPPABLE_VIDEO);
        Appodeal.show(Appodeal.NON_SKIPPABLE_VIDEO);
    }

    void ShowInterstitial() {
        Appodeal.initialize(appKey, Appodeal.INTERSTITIAL);
        Appodeal.show(Appodeal.INTERSTITIAL);
    }
}
