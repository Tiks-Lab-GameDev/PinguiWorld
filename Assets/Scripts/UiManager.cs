using UnityEngine;
using System.Collections;

public class UiManager : MonoBehaviour
{
    BirdMovement bd;
    GameObject pl;

    void Start()
    {
        pl = GameObject.FindGameObjectWithTag("Player");
        bd = pl.GetComponent<BirdMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("scene");
    }

    public void Settings()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Settings");
    }

    public void Exit()
    {
        Application.Quit();

    }

    public void Back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }

    public void Pause()
    {

        if (!bd.IsPause)
        {
            bd.IsGuiClick = true;
            Time.timeScale = 0;
            bd.IsPause = true;
        }
        else
        {
            bd.IsGuiClick = false;
            Time.timeScale = 1;
            bd.IsPause = false;
            if (GameObject.Find("Start_but")) { Destroy(GameObject.Find("Start_but")); }
        }
    }

    public void GodMod() { if (PlayerPrefs.GetInt("GodMod") == 0) { PlayerPrefs.SetInt("GodMod", 1); Debug.Log(PlayerPrefs.GetInt("GodMod")); } else PlayerPrefs.SetInt("GodMod", 0); }
}
