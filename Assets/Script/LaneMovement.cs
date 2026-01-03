using UnityEngine;

public class LaneMovement : MonoBehaviour
{
    [SerializeField] Transform playerCarTransform;
    [SerializeField] float offset = -5;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 camerapos = transform.position;
        camerapos.z = playerCarTransform.position.z + offset;
        transform.position = camerapos;
    }
}
                                               
