using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float moveSpeed;
    public float jumpHeight;
    public bool freezeRotation;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private bool grounded;
    
    private bool doubleJump;

    float lockPos = 0;

    // Use this for initialization
    void Start () {
        doubleJump = false;
    }

    void FixedUpdate ()
    {
        //Debug.Log (grounded);

        if (grounded) {
            doubleJump=false;
            //string s = "Grounded";
            //Debug.Log(s);
        }
        if (Input.GetKeyDown (KeyCode.Space) && grounded) {
            string s = "Getting in here";
            Debug.Log(s);
            Jump();
        }
        
        if (Input.GetKeyDown (KeyCode.Space) && Input.GetKeyDown(KeyCode.P) && !doubleJump && !grounded) {
            string s = "Not Grounded";
            Debug.Log (s);
            Jump ();
            doubleJump = true;
        }

        //directions
        if (Input.GetKey (KeyCode.L)) {
            GetComponent<Rigidbody> ().AddForce(transform.right * moveSpeed, ForceMode.Acceleration);
        }
        if (Input.GetKey (KeyCode.J)) {
            GetComponent<Rigidbody> ().AddForce(-transform.right * moveSpeed, ForceMode.Acceleration);
        }
        if (Input.GetKey (KeyCode.I)) {
            GetComponent<Rigidbody> ().AddForce(transform.forward * moveSpeed, ForceMode.Acceleration);
        }
        if (Input.GetKey (KeyCode.K)) {
            GetComponent<Rigidbody> ().AddForce(-transform.forward * moveSpeed, ForceMode.Acceleration);
        }

    }
    
    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Ground")
        {
            grounded = true;
        }
    }

    
    // Update is called once per frame
    void Update () {
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }
    
    public void Jump(){
        GetComponent<Rigidbody>().velocity = new Vector3 (GetComponent<Rigidbody> ().velocity.x, jumpHeight);

        grounded = false;
    }


}
