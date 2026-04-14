using UnityEngine;

public class bola : MonoBehaviour
{
    //movimiento de la bola para que abra la puerta 
    public float force = 10f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force, ForceMode.Force);
        }
    }

}
