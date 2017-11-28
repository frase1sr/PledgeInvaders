using Assets.Code;
using Assets.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorMain : MonoBehaviour
{

    // Use this for initialization
    public Transform AIAttacker;
    public GameObject Barrier;
    public GameObject PathAlgObject;
    public int BarrierGapFromPlayer;
    public int GapFromWallForBarriers;
    public int InitialAmountOfAISpawn;
    public int NumberOfObjects;
    public float SpawnTimer;
    public float SpawnTimerDec;
    public float SpawnTimerMin;
    public int AISpawnedBeforeDec;

    private SurvivorGameModel Game;
    private float Timer = 0f;
    private int NumberOfAISpawned = 0;
    void Start()
    {
        Game = new SurvivorGameModel(1, NumberOfObjects);
        GenerateMap(Game);
        Instantiate(PathAlgObject);
        SpawnAI(AIType.Hard, InitialAmountOfAISpawn, Game);

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= SpawnTimer)
        {
            Timer = 0f;
            SpawnAI(AIType.Hard, InitialAmountOfAISpawn, Game);
            if (AISpawnedBeforeDec == NumberOfAISpawned)
            {
                NumberOfAISpawned = 0;
                SpawnTimer =-SpawnTimerDec;
            }
        }
    }
    private void SpawnAI(AIType aiType, int number, SurvivorGameModel game)
    {
        NumberOfAISpawned++;
        for (int x = 0; x < number; x++)
        {
            var aiModel = new AttackerAIModel(aiType);
            var aiClone = Instantiate(AIAttacker, new Vector3(Random.Range(0 + game.MapOffSet.x, game.MapWidth + game.MapOffSet.x), 0, game.MapLength + (game.MapOffSet.z - 1)), Quaternion.identity);
            aiClone.GetComponent<AIMain>().Init(aiModel);
        }
    }
    private void GenerateMap(SurvivorGameModel game)
    {

        Mesh mesh = this.gameObject.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = new Vector2[vertices.Length];
        Bounds bounds = mesh.bounds;
        game.MapOffSet = bounds.center;
        game.MapWidth = bounds.size.x;
        game.MapLength = bounds.size.z;
        Random random = new Random();
        for (int i = 0; i < game.NumberOfObjects; i++)//TODO:game.Objects?
        {
            Vector3 position = new Vector3(Random.Range((0 + game.MapOffSet.x),
                game.MapWidth + game.MapOffSet.x),
                0,
                Random.Range(0 + game.MapOffSet.z + BarrierGapFromPlayer, (game.MapLength + game.MapOffSet.z) - GapFromWallForBarriers));
            var barrier = new BarrierModel(3, 0);
            var barrierClone = Instantiate(Barrier, position, Quaternion.identity);
            barrierClone.GetComponent<BarrierMain>().Init(barrier);

        }
    }
}
