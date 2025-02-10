using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;

    private Rigidbody rb;

    void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void MovePlayer(Vector3 direction) 
    {
        Vector3 moveDirection = new(direction.x, direction.y, direction.z);
        rb.AddForce(speed * moveDirection);
    }
}
