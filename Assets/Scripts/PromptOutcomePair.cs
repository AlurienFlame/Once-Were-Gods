using UnityEngine;

[CreateAssetMenu(fileName = "New PromptOutcomePair", menuName = "PromptOutcomePair")]
public class PromptOutcomePair : ScriptableObject
{
    public string title;
    public string prompt;
    public Sprite image;

    public bool repeatable;

    // Left choice
    public string leftOption;
    public string leftOutcome;
    // TODO: resource value changes

    // Right choice
    public string rightOption;
    public string rightOutcome;
    // TODO: resource value changes

}
