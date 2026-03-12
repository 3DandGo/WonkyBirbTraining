using UnityEngine;

public class IceMovementScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -9;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Ice Deleted");
            Destroy(gameObject);
        }
    }
}
