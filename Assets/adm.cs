using UnityEngine;
using System.Collections;
using admob;

public class adm : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Admob.Instance().initAdmob("ca-app-pub-8766905369625782/1806104953", "ca-app-pub-8766905369625782/1806104953");//admob id with format ca-app-pub-279xxxxxxxx/xxxxxxxx
        Admob.Instance().showBannerRelative(admob.AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
