using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static LevelManager Instance { set; get; }

    private int hitpoint = 3;
    private int score = 0;

    public Transform spawnPosition;

    public Transform playerTransform;
	private void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update () {
        if (playerTransform.position.y < -10)
        {
            playerTransform.position = spawnPosition.position;
            hitpoint--;
            if (hitpoint <= 0)
            {
                print("Failed");
            }
        }
	}

    public void Win()
    {
        print("WIn");
    }
}
