using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public TMP_Text countText; //text variable to hold score
    public TMP_Text winText;

    public float jumpForce = 5f;
    public float speed = 10.0f; //sets speed variable
    private Rigidbody rb;
    private int count;
    private bool isGrounded = true;

    //holds movement x and y
    private float movementX;
    private float movementY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0; //sets count to 0
        SetCountText(); //calls SetCountText function
        rb = GetComponent<Rigidbody>(); //sets rididbody component to rb
        winText.gameObject.SetActive(false); //sets win text to inactive at start

    }

    void OnMove(InputValue movementValue)
    {
        //Create a vector 2 variable and store the x and y movement values in it

        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void OnJump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //set the movement to the x and z variables (keep y at 0)
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);

        if (transform.position.y < -1f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        //check if the object we are colliding with has the tag "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //check if the object we are no longer colliding with has the tag "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //check if the game object we collided with has the tag "PickUp"
        if (other.gameObject.CompareTag("PickUp"))
        {
            //if it does, set the other object to inactive
            other.gameObject.SetActive(false);

            //add one to the score variable
            count++;
            SetCountText();

        }
    }

    System.Collections.IEnumerator ReloadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 10)
        {
            winText.gameObject.SetActive(true);

            StartCoroutine(ReloadSceneAfterDelay(3f));
        }
    }
}
