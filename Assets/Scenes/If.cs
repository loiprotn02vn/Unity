using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int playerLocation = 10;
        int spawnLocation = 20;
        if(playerLocation == spawnLocation)
        {
          this.Spawn();
        }
        else
        {
            this.NotSpawn();
        }
    }
    void Spawn()
    {
        Debug.Log("Spawned!");
    }
    void NotSpawn()
    {
        Debug.Log("Not Spawned!");
        
    }


}
