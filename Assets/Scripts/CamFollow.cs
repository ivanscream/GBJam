using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private GameObject target;        
    public float smoothSpeed = 3f; 
    public Vector3 offset;
    public Vector3 minValue, maxValue;

    void Update()
    {
        target = GameObject.FindWithTag("Player");
    }
    void LateUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        desiredPosition.z = transform.position.z;

        Vector3 boundPosition = new Vector3 (
            Mathf.Clamp(desiredPosition.x, minValue.x, maxValue.x),
            Mathf.Clamp(desiredPosition.y, minValue.y, maxValue.y),
            Mathf.Clamp(desiredPosition.z, minValue.z, maxValue.z));

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, boundPosition, 
        smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
    }
}
