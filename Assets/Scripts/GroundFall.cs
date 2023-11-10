using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

 
 

public class GroundFall : MonoBehaviour 

{ 

    private Rigidbody rb; 

 
 

    private void Start() 

    { 

        rb = GetComponent<Rigidbody>(); 

    } 

 
 

    private void OnCollisionExit(Collision collision) 

    { 

        if(collision.gameObject.tag == "Player") 

        { 

            StartCoroutine(values()); 

        } 

    } 

     

    public IEnumerator values() 

    { 

        yield return new WaitForSeconds(0.80f); 

        rb.useGravity = true; 

        rb.isKinematic = false; 

        Destroy(gameObject, 4); 

    } 

} 

 