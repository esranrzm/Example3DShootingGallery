using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Transform brick;
    private float offset = 2.0f;

    public static int score; //static so that we can access it in another script
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            // Quaternion.identity setting the global location of things //0,0,0 just on the player
            Instantiate(brick, new Vector3((i * offset) - 10, 0, 8), Quaternion.identity);
        }

        for (int i = 0; i < 10; i++)
        {
            // Quaternion.identity setting the global location of things //0,0,0 just on the player
            Instantiate(brick, new Vector3((i * offset) - 10, 0, 12), Quaternion.identity);
        }

        for (int i = 0; i < 10; i++)
        {
            // Quaternion.identity setting the global location of things //0,0,0 just on the player
            Instantiate(brick, new Vector3((i * offset) - 10, 2, 12), Quaternion.identity);
        }

    }

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }
}
