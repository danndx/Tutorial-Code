using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SCR_ChangeUiText : MonoBehaviour
{
    // UI Text GameObjects
    public GameObject textmeshpro_objective;
    public GameObject textmeshpro_distance;
    public GameObject legacy_objective;
    public GameObject legacy_success;

    // Game Variables
    public string objective_a;
    public float distance;
    public string objective_b;
    public bool success;

    // Text Components
    TextMeshProUGUI textmeshpro_objective_text;
    TextMeshProUGUI textmeshpro_distance_text;
    Text legacy_objective_text;
    Text legacy_success_text;

    void Start()
    {
        // Text Mesh Pro
        textmeshpro_objective_text = textmeshpro_objective.GetComponent<TextMeshProUGUI>();
        textmeshpro_distance_text = textmeshpro_distance.GetComponent<TextMeshProUGUI>();

        // Legacy
        legacy_objective_text = legacy_objective.GetComponent<Text>();
        legacy_success_text = legacy_success.GetComponent<Text>();
    }

    void Update()
    {
        // Text Mesh Pro
        textmeshpro_objective_text.text = objective_a;
        textmeshpro_distance_text.text = distance.ToString();

        // Legacy
        legacy_objective_text.text = objective_b;
        legacy_success_text.text = success.ToString();
    }
}
