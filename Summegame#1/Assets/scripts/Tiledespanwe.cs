using UnityEngine;

public class Tiledespanwe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GroundSection ground = other.GetComponent<GroundSection>();
        if (ground !=null) 
        {
            Destroy (other.gameObject);
        }
    }
}
