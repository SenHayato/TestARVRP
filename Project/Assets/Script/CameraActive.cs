using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CameraActive : MonoBehaviour
{
    [SerializeField] float moveSensitivity;
    [SerializeField] float rotationX = 0f;
    [SerializeField] float rotationY = 0f;

    private float smoother = 100f;
    void Start()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(0f,0f,0f);

        moveSensitivity = Mathf.Clamp(moveSensitivity, 0f, 10f);
    }

    void DragCamera()
    {
        if (Input.GetMouseButton(0))
        {
            rotationX += Input.GetAxis("Mouse X") * moveSensitivity * smoother;
            rotationY -= Input.GetAxis("Mouse Y") * moveSensitivity * smoother;

            rotationY = Mathf.Clamp(rotationY, -90f, 90f);

            transform.eulerAngles = new Vector3 (rotationY, rotationX, 0f); //Dibalik menyesuaikan sumbu
        }
    }

    void Update()
    {
        DragCamera();
    }
}
