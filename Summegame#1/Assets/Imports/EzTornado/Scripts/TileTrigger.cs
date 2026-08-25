using UnityEngine;

public class TileTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] roadSections;

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        
        if (player != null)
        {
            // Pick a random tile 
            // Genereate a random index to choose a random tile from the array
            int randomIndex = Random.Range(0, roadSections.Length);
            // Grab the tile at the randomly index
            GameObject tile = roadSections[randomIndex];
            /// Spawn that tile in front of the player
            Instantiate (tile, new Vector3 (0,0, transform.position.z + 50f), Quaternion.identity);
            Destroy(this);
        }
    }

}
