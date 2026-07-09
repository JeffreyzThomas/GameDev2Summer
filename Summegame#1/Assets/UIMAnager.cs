using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance {get; private set;}

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject GameOver;
    // Awake() Called when this gameobject is enabled in the scene
    private void Awake()
    {
        // Check Singleton
        // If there is no other instance of this script in the scene...
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            // Destroy any duplicates of this script
            Destroy(gameObject);
       ToggleGameOverUI(false);        
        }
        //here the panel for the game is being tunred off   
        GameOver.SetActive(false); 
    } 

    public void UpdateScore(int Distance)
    {
        // Update the score text object with the given score
        scoreText.text = $"Distance: {Distance}";
    }


    public void ToggleGameOverUI(bool flag)
    {
        GameOver.SetActive(flag);
    }
}
