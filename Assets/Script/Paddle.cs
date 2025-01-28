using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private string vertInputAxis = "VerticalP1";
    [SerializeField] Rigidbody rb;
    float vertInput;
    float speed = 10.0f;

    void Update()
    {
        vertInput = Input.GetAxis(vertInputAxis);
    }

    private void FixedUpdate()
    {
        Vector3 movement = Vector3.up * vertInput * speed * Time.fixedDeltaTime;
        Vector3 newPos = transform.position + movement;
        newPos.y = Mathf.Clamp(newPos.y, -4f, 4f);
        rb.MovePosition(newPos);
    }
}
