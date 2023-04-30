using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    PrometeoCarController _prometeoCar;
    [SerializeField]
    private Text _driftMultiplicatorText;
    [SerializeField]
    private Text _driftScoreText;
    [SerializeField]
    private Transform _driftScoreMenu;
    
    private int _driftMultiplicator = 1;
    [SerializeField]
    private int _driftScore = 0;


    void FixedUpdate()
    {
        if (_prometeoCar.isDrifting)
            EditScore();
    }


    private void EditScore()
    {
        _driftScoreMenu.gameObject.SetActive(true);
        _driftMultiplicatorText.text = "X" + _driftMultiplicator;
        _driftScore += 1 * _driftMultiplicator;
        _driftScoreText.text = "SCORE: " + _driftScore;
        if (_driftScore % 400 == 0)
            _driftMultiplicator++;
    }
}
