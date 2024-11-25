using UnityEngine;

public class cameralogic : MonoBehaviour
{
    public float movespeed = 5f;
    public float max = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputAD = Input.GetAxis("Horizontal");
        Vector3 PlayerMovement = new Vector3(0, 0, -inputAD);
        Vector3 movement = transform.position += PlayerMovement * movespeed * Time.deltaTime;

        movement.z= Mathf.Clamp(movement.z, -max, max);
        transform.position = movement;
    }
}
