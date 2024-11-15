using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody _rb;
    public float jumpForce = 5;
    public Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyUp(KeyCode.Space))
     {
        _rb.AddForce(Vector3.up * jumpForce,ForceMode.VelocityChange);
        playerAnim.SetTrigger("Jump_trig");
     }
        
    }
}
