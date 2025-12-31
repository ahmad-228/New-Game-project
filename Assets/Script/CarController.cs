using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public WheelCollider frontRightWheelCollider;
    public WheelCollider backRightWheelCollider;
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider backLeftWheelCollider;

    public Transform frontRightWheelTransform;
    public Transform backRightWheelTransform;
    public Transform frontLeftWheelTransform;
    public Transform backLeftWheelTransform;

    public Transform carCenterofmasstransform;
    public Rigidbody rigidbody;

    public float motorForce = 100f;
    public float steeringAngle = 30f;
    public float breakforce = 1000f;
    float verticalInput;
    float horizontalInput;
    void Start()
    {
        rigidbody.centerOfMass = carCenterofmasstransform.localPosition;
    }

    // Update is called once per frame
   

    void FixedUpdate()
    {
        MotorForce();
        UpdateWheel();
        GetInput();
        steering();
        applyBrakes();
    }

    void GetInput()
    {
        verticalInput=Input.GetAxis("Vertical");
        horizontalInput=Input.GetAxis("Horizontal");
    }
    void applyBrakes()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            frontRightWheelCollider.brakeTorque = breakforce;
            backRightWheelCollider.brakeTorque = breakforce;
            frontLeftWheelCollider.brakeTorque = breakforce;
            backLeftWheelCollider.brakeTorque = breakforce;
        }
        else
        {
            frontRightWheelCollider.brakeTorque =0f;
            backRightWheelCollider.brakeTorque = 0f;
            frontLeftWheelCollider.brakeTorque = 0f;
            backLeftWheelCollider.brakeTorque = 0f;
        }
       
    }
    void MotorForce()
    {
        frontRightWheelCollider.motorTorque = motorForce * verticalInput;
        frontLeftWheelCollider.motorTorque = motorForce * verticalInput;
    }
    void steering()
    {
        frontRightWheelCollider.steerAngle = steeringAngle * horizontalInput ;
        frontLeftWheelCollider.steerAngle = steeringAngle * horizontalInput ;
    }
    void UpdateWheel()
    {
        RotateWheel(frontRightWheelCollider, frontRightWheelTransform);
        RotateWheel(backRightWheelCollider, backRightWheelTransform);
        RotateWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        RotateWheel(backLeftWheelCollider, backLeftWheelTransform);
    }
    void RotateWheel(WheelCollider wheelCollider,Transform transform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        transform.position = pos;
        transform.rotation = rot;
    }
}
