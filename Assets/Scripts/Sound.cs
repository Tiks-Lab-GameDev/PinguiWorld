using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
   static AudioSource track;

    // Use this for initialization
    void Start () {
        track = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void PlaySound()
    {
        track.Play();
    }

}
