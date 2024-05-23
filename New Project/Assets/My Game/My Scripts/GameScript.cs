using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public EnemySpawner mySpawner;
    public int enemiesToSpawn;
    public int waveCount=0;
    public int winWave=5;
    public GameObject cutscene;

    // Use this for initialization
    protected void Start () {
	     enemiesToSpawn = waveCount*2;
		
	}

    public void SpawnWave()
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            mySpawner.Invoke("Spawn",i);
        }
    }

    // Update is called once per frame
    protected void Update () {
        
        if (mySpawner.transform.childCount == 0 && EnemySpawner.activated && !IsInvoking())
        {
            waveCount++;
            HUD.Message("WAVE"+ " " + waveCount);
            enemiesToSpawn=Random.Range(waveCount*2, waveCount*4);
            Invoke("SpawnWave",3);
        }

        if (waveCount > winWave)
        {
            mySpawner.gameObject.SetActive(false);
            cutscene.SetActive(true);
            return;
        }
	}
}