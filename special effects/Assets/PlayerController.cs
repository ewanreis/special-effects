using UnityEngine;
public class PlayerController : MonoBehaviour
{   CharacterController characterController;
    public float Gravity = 9.8f, velocity = 0, MovementSpeed = 1;
    private Camera cam;
    public string mode = "pc";
    private void Start()
    {   characterController = GetComponent<CharacterController>();
        cam = Camera.main;
    }void Update()
    {   if (mode == "pc")
        {   float horizontal = Input.GetAxis("Horizontal") * MovementSpeed, vertical = Input.GetAxis("Vertical") * MovementSpeed;
            characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);       
            if (characterController.isGrounded) // Gravity
                velocity = 0;
            else
                characterController.Move(new Vector3(0, velocity -= Gravity * Time.deltaTime, 0));
        }if (mode =="vr")
        { // vr movement code
        }
    }
}