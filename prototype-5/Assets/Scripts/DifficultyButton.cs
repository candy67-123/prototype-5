using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        button.onClick.AddListener(SetDifficuity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficuity()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame();
    }

}

