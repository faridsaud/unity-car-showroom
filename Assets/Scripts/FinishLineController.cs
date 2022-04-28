using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineController : MonoBehaviour
{
    private string _winnerTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_winnerTag == null)
        {
            SetWinner(other.tag);
            StopGame();
        }
    }

    private void SetWinner(string winnerTag)
    {
        _winnerTag = winnerTag;
        GameObject winnerTextbox = GameObject.FindGameObjectsWithTag("Winner")[0];
        winnerTextbox.GetComponent<TextMeshProUGUI>().SetText($"The winner is: {_winnerTag}");
    }

    private void StopGame()
    {
        GameObject resumeButton = GameObject.FindGameObjectsWithTag("Resume")[0];
        resumeButton.GetComponent<Button>().onClick.Invoke();
        
    }
}
