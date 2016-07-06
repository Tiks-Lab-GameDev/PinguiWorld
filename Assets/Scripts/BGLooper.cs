using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

    Vector3 pos;

    int numBGPanels = 12;
    float pipeMax = 0.8430938f;
	float pipeMin = -0.003243029f;
    float widthOfBGObject,posx,posy;
    int posFish;
    GameObject go;
    int num;


    void Start() {
		GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");
        foreach(GameObject pipe in pipes) {
            pos = pipe.transform.position;
			pos.y = Random.Range(pipeMin, pipeMax);
			pipe.transform.position = pos;
		}
        posFish = Random.Range(1,10);//в метод писать сколько надо - 14
        num = 0;
	}

	void OnTriggerEnter2D(Collider2D collider)
    {
        Loop(collider);
    }

    private void Loop(Collider2D collider)
    {
        Debug.Log("Triggered: " + collider.name);
        pos = collider.transform.position;
        widthOfBGObject = ((BoxCollider2D)collider).size.x;

		if (collider.tag == "Pipe") PipeLoop(collider);
        else
        {
            if (collider.tag == "BG") BgLoop(collider);
            else pos.x += widthOfBGObject * numBGPanels;
        }
        collider.transform.position = pos;
    }

	void PipeLoop(Collider2D col)
    {
        Debug.Log("pos" + posFish + " num" + num);
        if (posFish == (num-3)) { go = GameObject.Find("PipesPreFish"); }
        else go = GameObject.Find ("PipesPre");
		posy = pos.y = Random.Range(pipeMin, pipeMax);
		posx = pos.x += widthOfBGObject * numBGPanels;
		Destroy (col.gameObject);
		Instantiate (go,new Vector3(posx,posy),new Quaternion());
        if (go == GameObject.Find("PipesPreFish")){ Destroy(go); }
        num += 1;
        
    }

    void BgLoop(Collider2D collider) {
        pos.x += (widthOfBGObject * collider.transform.lossyScale.x) * numBGPanels;
    }
}
