using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to RigidBody component
    public Rigidbody rb;

    //floats are for decimals 
    public float forwardForce = 2000f;
    public float sideForce = 600f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hellooo!");

    }
    //renamed to FixedUpdate as the phsyics engine likes it better
    // Update is called once per frame
    void FixedUpdate()
    {
        //forward directional force 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(rb.position.y < -2)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
