using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PromptOutcomePair", menuName = "PromptOutcomePair")]
public class PromptOutcomePair : ScriptableObject
{
    public string title;
    public string prompt;
    public Sprite image;

    public bool repeatable;
    public List<string> prerequisites;

    // Left choice
    public string leftOption;
    public string leftOutcome;
    public List<string> leftUnlocks;
    // TODO: resource value changes

    // Right choice
    public string rightOption;
    public string rightOutcome;
    public List<string> rightUnlocks;
    // TODO: resource value changes

}
