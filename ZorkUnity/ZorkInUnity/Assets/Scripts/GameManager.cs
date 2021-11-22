using System;
using UnityEngine;
using TMPro;
using Zork;

public class GameManager : MonoBehaviour
{

    private void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);



        Game.Start(gameJsonAsset.text, InputService, OutputService);
        Game.Instance.Output.WriteLine(Game.Instance.Player.Location);
        Game.Look(Game.Instance);
        
    }


    void Start()
    {
        LocationText.text = Game.Instance.Player.Location.ToString();
        ScoreText.text = Game.Instance.Score.ToString();
        MovesText.text = Game.Instance.Moves.ToString();
    }
    private void Update()
    {
        if (Game.Instance.RewardisCalled == true)
        {
            ScoreText.text = Game.Instance.Score.ToString();
        }
        if (Game.Instance.MoveIncremented == true)
        {
            MovesText.text = Game.Instance.Moves.ToString();
        }
        if (Game.Instance.differentRoom == true)
        {
            LocationText.text = Game.Instance.Player.Location.ToString();
        }
    }

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private TextMeshProUGUI LocationText;
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    [SerializeField]
    private TextMeshProUGUI MovesText;
    [SerializeField]
    private UnityOutputService OutputService;
    [SerializeField]
    private UnityInputService InputService;
}