using UnityEngine;

public class GroundSection : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
     
     private void FixedUpdate() //is the 50 fps-frames per second.
    {
        //
    transform.position += new Vector3 (0, 0, -moveSpeed) * Time.deltaTime;

    }


}
