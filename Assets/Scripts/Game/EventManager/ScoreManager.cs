using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Score;
    [SerializeField] private TextMeshProUGUI MaxScore;
    [SerializeField] private PlayerPoints PlayerScoreData;
    public PlayerManagerCollision player;
    public CandyPointsManager CandyManager;
    private CandyController _candyController;
    // Start is called before the first frame update
    void Start()
    {
        _candyController.GetComponent<CandyController>();
        PlayerScoreData.CurrentPoints = 0;
        UpdateScoreMaxScore();
        MaxScore.text = PlayerScoreData.MaxPoints.ToString();
        ShowCurrentScore();
    }

    private void Update()
    {
        UpdateScoreMaxScore();

        ShowCurrentScore();
    }
    private void OnEnable()
    {
        player.OnCollisionCandy += ScoreAdd;
    }
    private void OnDisable()
    {
        player.OnCollisionCandy -= ScoreAdd;
    }
    private void UpdateScoreMaxScore()
    {
        if (PlayerScoreData.CurrentPoints > PlayerScoreData.MaxPoints)
        {
            PlayerScoreData.MaxPoints = PlayerScoreData.CurrentPoints;
            MaxScore.text = PlayerScoreData.MaxPoints.ToString();
        }
    }
    private void ShowCurrentScore()
    {
        Score.text = PlayerScoreData.CurrentPoints.ToString();
    }
    void ScoreAdd()
    {
        AddScore();
    }
    void AddScore()
    {
        if (_candyController.GetComponent<CandyController>().Candy == "Candy1")
        {
            PlayerScoreData.CurrentPoints += CandyManager.Candy1;
        }
        if (_candyController.Candy == "Candy2")
        {
            PlayerScoreData.CurrentPoints += CandyManager.Candy2;
        }
        if (_candyController.Candy == "Candy3")
        {
            PlayerScoreData.CurrentPoints += CandyManager.Candy3;
        }
    }
}
