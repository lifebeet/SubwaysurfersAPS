using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   [SerializeField]
   private Transform target;
   [SerializeField]
   private float smoothSpeed = 0.125f;
   [SerializeField]

   private float minX;
   [SerializeField]
   private float maxX;
   [SerializeField]
   private float verticalThreshold = 2f;
   [SerializeField]
   private float verticalSmoothSpeed = 5f;
   private float Vector3 offset;
   private float currentY;

   private void Awake()
    {
        offset = transform.position - target.position;
        currentY = transform.position.y;
    }
    private void LateUpdate()
    {
        Vector3 position = transform.position;
        float tragetX = target.position.x + offset.x;
        position.x = Mathf.Clamp(tragetX, minX, maxX);
        position.z = target.position.z + offset.z;
        float targetY = target.position.y + offset.y;
        if (targetY >currentY)
        {
            if(targetY > currentY + verticalThreshold)
            {
                currentY = Mathf.lerp(currentY, targetY, verticalSmoothSpeed * Time.deltatime);
            }
        }
        else if (targetY < currentY)
        {
            currentY = Mathf.Lerp(currentY,targetY, verticalSmoothSpeed * Time.deltaTime);

        }
        position.y = currentY;
        transform.position = Vector3.Lerp(trasnform.position, position, smoothSpeed);
    }



        
    
}
