using UnityEngine;
using Unity.Cinemachine;

public class ArrowIndicator : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freeLookCamerea;

    void Update()
    {
        transform.forward = freeLookCamerea.transform.forward;
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
