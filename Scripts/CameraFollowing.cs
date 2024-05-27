using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CameraFollowing : MonoBehaviour{
    
    [SerializeField] GameObject followItem;

    public void Update(){
        
    }

    private void KeepFollowing(GameObject target){
        if(target != null){
            this.transform.right = followItem.transform.right;
        }

    }
}
