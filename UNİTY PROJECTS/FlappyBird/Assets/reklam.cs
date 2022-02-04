using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class reklam : MonoBehaviour
{
    InterstitialAd interstitial;


    void Start()
    {
        #if UNITY_ANDROID
        string appId = "ca - app - pub - 5883476300385685~6418260736";

        #endif
        
        MobileAds.Initialize(appId);

        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        #elif UNITY_IPHONE
                string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
                string adUnitId = "unexpected_platform";
        #endif

                
              interstitial = new InterstitialAd(adUnitId);

        List<string> deviceIds = new List<string>();
        deviceIds.Add("2077ef9a63d2b398840261c8221a0c9b");
        RequestConfiguration.Builder requestConfigurationBuilder = new RequestConfiguration
            .Builder()
            .SetTestDeviceIds(deviceIds)
            .Build();
        interstitial.LoadAd(requestConfigurationBuilder);





    }

    
    void Update()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
}
