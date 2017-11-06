using Assets.Code;
using Assets.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorMain : MonoBehaviour
{

    // Use this for initialization
    public Transform AIAttacker;
    public Transform Barrier;
    void Start()
    {
        var game = new SurvivorGameModel();
        var player = new SurvivalPlayerModel();
        var aiModel = new AttackerAIModel(AIType.Hard);
        GenerateMap(game);
        for (int x = 0; x < 1; x++)
        {
            var aiClone  = Instantiate(AIAttacker, new Vector3(6, 1, 6), Quaternion.identity);
            aiClone.GetComponent<AIMain>().Init(aiModel);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    void GenerateMap(SurvivorGameModel game)
    {
        Random random = new Random();
        var width = game.MapWidth;
        var length = game.MapLength;
        
        for (int i = 0; i < 10; i++)//TODO:game.Objects?
        {
            Vector3 position = new Vector3(Random.Range(0, width), 0, Random.Range(0, length));
            var barrier = new BarrierModel()
            {
                Health = 3,
                Type = 0
            };
            var barrierClone = Instantiate(Barrier, position, Quaternion.identity);
            barrierClone.GetComponent<BarrierMain>().Init(barrier);

        }
    }
}
