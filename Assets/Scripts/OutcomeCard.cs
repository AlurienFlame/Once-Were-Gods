using UnityEngine;
using TMPro;

public class OutcomeCard : MonoBehaviour
{
    public TextMeshProUGUI outcome;

    public void SetData(PromptOutcomePair data, string choice)
    {
        if (choice == "left")
        {
            outcome.text = data.leftOutcome;
        }
        else if (choice == "right")
        {
            outcome.text = data.rightOutcome;
        }
    }

    public void MoveToBottom()
    {
        this.transform.SetAsFirstSibling();
    }
}
