using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI distanceText;
    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] Transform carTransform;
    [SerializeField] CarController carController;

    float speed;
    float distance;
    float score;

    Vector3 lastPos;

    void Start()
    {
        if (carTransform != null)
            lastPos = carTransform.position;
    }

    void Update()
    {
        if (carTransform != null)
            DistanceCal();

        if (carController != null)
            SpeedCal();

        ScoreCal();
    }

    // ✅ Real distance traveled
    void DistanceCal()
    {
        float delta = Vector3.Distance(carTransform.position, lastPos);
        distance += delta;
        lastPos = carTransform.position;

        distanceText.text = Mathf.RoundToInt(distance) + " m";
    }

    void SpeedCal()
    {
        speed = carController.CarSpeed();
        speedText.text = Mathf.RoundToInt(speed) + " km/h";
    }

    // ✅ SIMPLE SCORE LOGIC
    void ScoreCal()
    {
        // 1 point per meter + speed bonus
        score = distance + (speed * 0.1f);

        scoreText.text = Mathf.RoundToInt(score).ToString();
    }
}
