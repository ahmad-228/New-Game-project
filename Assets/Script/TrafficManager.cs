using System.Collections;
using UnityEngine;

public class TrafficManager : MonoBehaviour
{
    [SerializeField] Transform[] lane;
    [SerializeField] GameObject[] trafficVehicle;
    [SerializeField] CarController carController;
    void Start()
    {
        StartCoroutine(TrafficSpawner());
    }

    IEnumerator TrafficSpawner()
    {
        while (true)
        {
            float speed = carController.CarSpeed();

            // normalize speed (0–1)
            float t = Mathf.InverseLerp(10f, 60f, speed);

            // higher speed → smaller wait
            float waitTime = Mathf.Lerp(6f, 2f, t);

            SpawnTrefficVehicle();

            yield return new WaitForSeconds(waitTime);
        }
        }
    void SpawnTrefficVehicle()
    {
        int randomLaneIndex = Random.Range(0, lane.Length);
        int randomVehicleIndex = Random.Range(0, trafficVehicle.Length);
        Instantiate(
            trafficVehicle[randomVehicleIndex],
            lane[randomLaneIndex].position,
            Quaternion.identity
        );
    }
}
