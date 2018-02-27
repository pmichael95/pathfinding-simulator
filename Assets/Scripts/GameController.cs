﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region ABOUT
    /**
     * The Controller for the game.
     * It holds state variables such as what algorithm we're using.
     */ 
    #endregion

    #region VARIABLES
    public enum AlgorithmChoice { Dijkstra, AStar, Cluster };
    public static AlgorithmChoice currentAlgorithm;
    public AlgorithmChoiceDisplay currentAlgorithmText;
    #endregion

    /// <summary>
    /// Initializes the current algorithm to its default, and finds the appropriate text object.
    /// </summary>
	void Start () {
        // By default, we start with Dijkstra's algorithm for path finding
        currentAlgorithm = AlgorithmChoice.Dijkstra;
        if (!currentAlgorithmText)
        {
            currentAlgorithmText = GameObject.Find("Current_Algorithm").GetComponent<AlgorithmChoiceDisplay>();
        }
	}
	
	/// <summary>
	/// Detects keyboard input to change algorithm modes.
	/// </summary>
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Swap to Dijkstra's algorithm
            currentAlgorithm = AlgorithmChoice.Dijkstra;
            currentAlgorithmText.ChangeAlgorithm();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Swap to A* algorithm
            currentAlgorithm = AlgorithmChoice.AStar;
            currentAlgorithmText.ChangeAlgorithm();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Swap to Cluster algorithm
            currentAlgorithm = AlgorithmChoice.Cluster;
            currentAlgorithmText.ChangeAlgorithm();
        }
	}
}