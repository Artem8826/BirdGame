using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 startPos;
    private Camera cam;
    private Transform selfTransform;

    private void Start()
    {
        cam = GetComponent<Camera>();
        selfTransform = transform;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = cam.ScreenToWorldPoint(Input.mousePosition);
            
        }
        else if (Input.GetMouseButton(0))
        {
            float posX = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
            float posY = cam.ScreenToWorldPoint(Input.mousePosition).y - startPos.y;
            selfTransform.position = 
                new Vector3(Mathf.Clamp(selfTransform.position.x - posX, -0.455f, 0.455f), Mathf.Clamp(selfTransform.position.y - posY, -0.702f, 0.702f), selfTransform.position.z);
        }
    }
}
