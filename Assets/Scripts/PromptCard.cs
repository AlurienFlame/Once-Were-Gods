using UnityEngine;
using TMPro;

public class PromptCard : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI prompt;

    public void SetData(PromptOutcomePair data)
    {
        title.text = data.title;
        prompt.text = data.prompt;

    }

    public void MoveToBottom()
    {
        this.transform.SetAsFirstSibling();
    }
}
