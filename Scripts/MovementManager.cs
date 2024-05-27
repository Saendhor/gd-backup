using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEditor.Rendering;
using UnityEngine;

public class MovementManager : MonoBehaviour{

    [SerializeField] Player player;
    [HideInInspector] public Rigidbody rb;

    private bool jumpQueued = false;

    public void Start(){
        if(player == null){
            return;
        }
        rb = player.GetComponent<Rigidbody>();
    }

    public void Update(){
        //Handle movement
        Movement();
    }

    public void FixedUpdate(){
        if(jumpQueued){
            Jump();
        }
    }

    private void Movement(){

        if(Input.GetKey(KeyCode.F)){
            transform.Translate(Vector3.right * Time.deltaTime * player.GetMovementSpeed(), Space.Self);
            //Debug.Log("Mi sposto verso destra con velocità " + moveSpeed );
        }

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.left * Time.deltaTime * player.GetMovementSpeed(), Space.Self);
            //Debug.Log("Mi sposto verso sinistra con velocità " + moveSpeed);
        }
        if(Input.GetKeyDown(KeyCode.Space) && player.GetIsOnGround()){
            jumpQueued = true;
        }
    }

    private void Jump(){
        rb.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
        player.SetIsOnGround(false);
        jumpQueued = false;
    }

   

}
