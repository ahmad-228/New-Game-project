using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    
    void Start()
    {
      int currentCarIndex= PlayerPrefs.GetInt("CarIndexValue", 0);
      Debug.Log("Spawned Car Index: " + currentCarIndex);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
