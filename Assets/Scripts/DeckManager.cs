using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public GameObject promptCard;
    public GameObject outcomeCard;
    public List<PromptOutcomePair> allPrompts;

    bool isOutcomeShowing = false;
    PromptOutcomePair currentPrompt;

    private void Start()
    {
        ChooseNextCard();
    }

    public void ChooseOption(string choice)
    {
        // Debug.Log($"Chose {choice} option!");

        if (isOutcomeShowing)
        {
            ChooseNextCard();

            // Animate
            if (choice == "left")
            {
                outcomeCard.GetComponent<Animator>().Play("CardSwipeLeft");
            }
            else if (choice == "right")
            {
                outcomeCard.GetComponent<Animator>().Play("CardSwipeRight");
            }

            isOutcomeShowing = false;
        }
        else
        {
            // TODO: Set story flags
            // TODO: Change resources

            // Reveal outcome card
            outcomeCard.GetComponent<OutcomeCard>().SetData(currentPrompt, choice);

            // Animate
            if (choice == "left")
            {
                promptCard.GetComponent<Animator>().Play("CardSwipeLeft");
            }
            else if (choice == "right")
            {
                promptCard.GetComponent<Animator>().Play("CardSwipeRight");
            }

            isOutcomeShowing = true;
        }
    }

    void ChooseNextCard()
    {
        // Find out which prompts are accessible at this point in the story
        List<PromptOutcomePair> validPrompts = new List<PromptOutcomePair>();
        foreach (PromptOutcomePair prompt in allPrompts)
        {
            // TODO: Check each prompt against story flags
            validPrompts.Add(prompt);
        }

        // Picks which prompt to show next
        currentPrompt = validPrompts[Random.Range(0, validPrompts.Count)];
        Debug.Log($"Next prompt is {currentPrompt.title}.");

        // Reveal next prompt
        promptCard.GetComponent<PromptCard>().SetData(currentPrompt);

        // TODO: Stop unrepeatable prompts from showing up twice.
    }
}

