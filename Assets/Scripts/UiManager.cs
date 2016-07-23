using UnityEngine;
using System.Collections;

public class UiManager : MonoBehaviour
{
    BirdMovement bd;
    GameObject pl;
    int nowPlay;
    bool isActive = false;
    bool isActive1 = false;

    void Start()
    {
        pl = GameObject.FindGameObjectWithTag("Player");
        bd = pl.GetComponent<BirdMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void Cust() { UnityEngine.SceneManagement.SceneManager.LoadScene("Customization"); }
    public void ChooseLvL()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("level");
    }
    public void PlaySand()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("sandLevel");
	}
    public void PlayIce()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("scene");
    }

    public void PlayJun()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("junglescene");
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
            if (GameObject.Find("Start_but")) { Destroy(GameObject.Find("Start_but"));bd.start = false; }
        }
    }

    public void Review() {
        Score.SaveSc();
        UnityEngine.SceneManagement.SceneManager.LoadScene("scene"); 
    }

    public void CloseBuy()
    {
        isActive = !isActive;
        GameObject.Find("Message").GetComponent<SpriteRenderer>().sprite = GameObject.Find("MessageBuy").GetComponent<SpriteRenderer>().sprite;
    }

    public void CloseErorr()
    {
        isActive1 = !isActive1;
        GameObject.Find("Message").GetComponent<SpriteRenderer>().sprite = GameObject.Find("MessageErorr").GetComponent<SpriteRenderer>().sprite;
    }

    public void CloseMessage()
    {
        GameObject.Find("Message").GetComponent<SpriteRenderer>().sprite = null;
    }
}
