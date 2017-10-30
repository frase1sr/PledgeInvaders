using Assets.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var game = new SurvivorGameModel();
        var player = new SurvivalPlayerModel();
        var AI = new AttackerAIModel(AIType.Easy);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void GenerateMap(SurvivorGameModel game)
    {
        Random random = new Random();
        var width = game.MapWidth;
        var length = game.MapLength;
        foreach (var obj in game.Objects)
        {
            Vector3 position = new Vector3(Random.Range(-10.0f,width), 0, Random.Range(-10.0f, length));
        }
    }
}
