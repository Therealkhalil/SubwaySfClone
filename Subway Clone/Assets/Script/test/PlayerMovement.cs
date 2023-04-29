using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    //placeholder positions for cube to jump to

    private int Direction;

    public float speed;
    private bool grounded;
    private bool immediateDown;
    private bool moved;

    public float movementslow;

    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    public static bool dead;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame (Right before frame)
    void Update()
    {
        grounded = Physics.OverlapSphere(groundCheck.position, groundRadius, whatIsGround).Length >= 1;
        //rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,10f);
        //Debug.Log(grounded);
        if (!dead)
        {
            Analyze();
            if (Input.GetKeyDown(KeyCode.Q))
            {

                if (Direction == 0 || Direction == 1)
                {
                    Direction--;
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {

                if (Direction == 0 || Direction == -1)
                {
                    Direction++;
                }
            }
            if (Input.GetKeyDown(KeyCode.Z) && grounded)
            {

                rb.AddForce(0, 1900f, 0);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {

                immediateDown = true;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag == "Platform")
        {
            Vector3 hit = collision.contacts[0].normal; //perpendicular in vector terms
            float angle = Vector3.Angle(hit, Vector3.up);
            if (Mathf.Approximately(angle, 90))
            {
                dead = true;
            }
        }*/
        if (collision.gameObject.tag == "Obs")
        {
            dead = true;
        }
    }

    void Analyze()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(4 * Direction, transform.position.y, transform.position.z), movementslow * Time.deltaTime);
    }

    // For physics updates
    void FixedUpdate()
    {
        if (immediateDown)
        {
            rb.AddForce(0, -3000f, 0);
            immediateDown = false;
        }
    }

}