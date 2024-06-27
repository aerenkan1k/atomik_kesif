using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ChracterController2 : MonoBehaviour
{
    public float jumpForce = 7;
    public float speed ;
    public float horizontalInput;
    public float verticalInput;

    private bool jump;
    private bool grounded = true;

    private AudioSource audioSource;
    public AudioClip bacgroundSound;

    private Vector3 charPos;
    private Rigidbody2D rigidbody2D;
    [AllowNull]
    [SerializeField] private GameObject camera;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        jumpForce = 8;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bacgroundSound;
        audioSource.Play();
        audioSource.loop = true;
    }

    private void FixedUpdate()
    {
        
        rigidbody2D.velocity = new Vector2(speed * horizontalInput, rigidbody2D.velocity.y);
        if (jump)
        {
            rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
            grounded = false;
        }
        charPos = transform.position;
    }


    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if(grounded && verticalInput > 0)
        {
            jump = true;
        }

    }
    private void LateUpdate()
    {
        if (camera != null)
            camera.transform.position = new Vector3(charPos.x, charPos.y, -10);
        else 
            Debug.Log("Kamera Tanımlı Degil.");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
}
