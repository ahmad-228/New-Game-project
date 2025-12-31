using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public WheelCollider frontRightWheelCollider;
    public WheelCollider backRightWheelCollider;
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider backLeftWheelCollider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frontRightWheelCollider.motorTorque = 10f;
        frontLeftWheelCollider.motorTorque = 10f;




    }
}
