// // using UnityEngine;

// // public class FirstPersonCameraController : MonoBehaviour
// // {
// //     public float sensitivity = 2.0f;

// //     float cameravert = 0f;

// //     public Transform player;

// //     private void Start()
// //     {
// //         Cursor.lockState = CursorLockMode.Locked;
// //         Cursor.visible = false;

// //         player = transform;
// //     }

// //     private void Update()
// //     {
// //         // Get mouse input
// //         Vector2 rawMouseInput = new Vector2(Input.GetAxisRaw("Mouse X")*sensitivity, Input.GetAxisRaw("Mouse Y")*sensitivity);

// //         cameravert -= rawMouseInput[1];
// //         cameravert = Mathf.Clamp(cameravert,-90f, 90f);
// //         transform.localEulerAngles = Vector3.right * cameravert;

// //         player.Rotate(Vector3.up * rawMouseInput[0]);

// //     }
// // }

// using UnityEngine;

// public class PlayerLookAround : MonoBehaviour
// {
//     public float sensitivity = 2.0f;

//     float cameravert = 0f;

//     public Transform player;

//     private void Start()
//     {
//         //Cursor.lockState = CursorLockMode.Locked;
//         //Cursor.visible = false;

//         player = transform; // Assuming the player is the parent of the camera
//     }

//     private void Update()
//     {

//         Vector2 rawMouseInput = new Vector2(Input.GetAxis("Mouse X") * sensitivity, Input.GetAxis("Mouse Y") * sensitivity);

//         cameravert -= rawMouseInput[1];
//         cameravert = Mathf.Clamp(cameravert, -90f, 90f);
//         transform.localEulerAngles = new Vector3(cameravert, rawMouseInput[0], 0f);

//         player.Rotate(Vector3.up * Input.GetAxis("Mouse X")*sensitivity);

//         Debug.Log("Mouse X: " + Input.GetAxisRaw("Mouse X"));
        
//     }
// }

using UnityEngine;

public class PlayerLookAround : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSensitivity = 2f;

    private float rotationX;
    private float rotationY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // move our camera forward, backward, left and right
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        //transform.position += new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;

        // rotate our camera
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        rotationY += mouseX;

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }
}