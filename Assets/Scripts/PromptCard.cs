using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PromptCard : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI prompt;
    public Image image;

    public void SetData(PromptOutcomePair data)
    {
        title.text = data.title;
        prompt.text = data.prompt;
        image.sprite = data.image;

    }

    public void MoveToBottom()
    {
        this.transform.SetAsFirstSibling();
    }
}
