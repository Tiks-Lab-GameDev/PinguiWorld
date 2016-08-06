using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    int nowPlay;
    bool isActive = false;
    bool isActive1 = false;
    BirdMovement bd;
    Main main;

    void Start()
    {
        main = GameObject.Find("Scripts").GetComponent<Main>();
        bd = GameObject.Find("PlayerBird").GetComponent<BirdMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void Cust() {
        SceneManager.LoadSceneAsync("Customization");
    }
    public void ChooseLvL()
    {
        SceneManager.LoadSceneAsync("level");
    }
    public void Restar()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
    public void PlaySand()
	{
        SceneManager.LoadSceneAsync("Load");
        Load.level = "sandLevel";
    }
    public void PlayIce()
    {

        SceneManager.LoadSceneAsync("Load");
        Load.level = "scene";
    }

    public void PlayJun()
    {
        SceneManager.LoadSceneAsync("Load");
        Load.level = "junglescene";
    }

    public void Settings()
    {
        SceneManager.LoadSceneAsync("Settings");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadSceneAsync("menu");
    }
    public void Loading()
    {
        SceneManager.LoadSceneAsync("Load");
    }

    public void Pause()
    {
        main.IsPause = !main.IsPause;
        if (main.IsPause)
        {
            bd.IsGuiClick = true;
            Time.timeScale = 0;
        }
        else
        {
            bd.IsGuiClick = false;
            Time.timeScale = 1;
            if (GameObject.Find("Start_but")) { Destroy(GameObject.Find("Start_but"));main.IsStart = false; }
        }
    }

    public void ReviewIce() {
        //SaveSc();
        ADS.ShowReward();
        SceneManager.LoadSceneAsync("scene"); 
    }

    public void ReviewDes()
    {
        //SaveSc();
        ADS.ShowReward();
        SceneManager.LoadSceneAsync("sandLevel");
    }

    public void ReviewJun()
    {
        //SaveSc();
        ADS.ShowReward();
        SceneManager.LoadSceneAsync("junglescene");
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
