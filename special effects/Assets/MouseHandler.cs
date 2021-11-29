using UnityEngine;
public class MouseHandler : MonoBehaviour
{   public float horizontalSpeed = 1f, verticalSpeed = 1f, xRotation = 0.0f, yRotation = 0.0f;
    private Camera cam;
    void Start()
    {   cam = Camera.main;
    }
    void Update()
    {   float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed, mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation -= mouseY, -90, 90);
        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
