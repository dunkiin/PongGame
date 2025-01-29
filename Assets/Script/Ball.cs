using System.Net.Http.Headers;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 7.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Reset()
    {
        // rb.linearVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        transform.position = Vector3.zero;
    }


    public void Launch()
    {
        Vector3 movement = GetRandomBallDirection() * speed;
        rb.AddForce(movement, ForceMode.Impulse);
    }

    Vector3 GetRandomBallDirection()
    {
        //if (Random.Range(0, 2) == 0)
        //{
        //    x = -1f;
        //}
        //if (Random.Range(0, 2) == 0)
        //{
        //    y = -1f;
        //}

        float x = Random.Range(0, 2) == 0 ? -1f : 1f;
        float y = Random.Range(0, 2) == 0 ? -1f : 1f;   

        Vector3 dir = new Vector3(x, y, 0);
        return dir;
    }


}
