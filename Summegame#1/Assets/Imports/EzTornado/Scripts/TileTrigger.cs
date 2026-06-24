using UnityEngine;

public class TileTrigger : MonoBehaviour
{
    [SerializeField] private GameObject roadSection;

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        
        if (player != null)
        {
            Instantiate (roadSection, new Vector3 (0,0, transform.position.z + 50f), Quaternion.identity);


            Destroy(this);
        }
    }

}
