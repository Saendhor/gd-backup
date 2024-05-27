using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public static Player Instance { get; private set; }

    private float moveSpeed = 12f;
    private bool isOnGround = true;

    private void Awake() {
        if (Instance != null) {
            Debug.LogError("There is more than one Player instance");
        }
        Instance = this;
    }
    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Walkable"){
            isOnGround = true;
        }
    }

    public float GetMovementSpeed(){
        return moveSpeed;
    }

    public void SetIsOnGround(bool status){
        this.isOnGround = status;
    }

    public bool GetIsOnGround(){
        return isOnGround;
    }

}