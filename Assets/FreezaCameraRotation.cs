using UnityEngine;

public class FreezeCameraRotation : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Quaternion.Euler(45f, transform.rotation.eulerAngles.y, 0f);
    }
}
