using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        guess = UnityEngine.Random.Range(min, max + 1);
        setView(guess);
    }

    public void onPressHigher()
    {
        NextGuess(true);
        setView(guess);
    }

    public void onPressLower()
    {
        NextGuess(false);
        setView(guess);
    }

    void NextGuess(bool goUp)
    {
        if (goUp)
        {
            min = guess + 1;
        }
        else
        {
            max = guess - 1;
        }
        guess = UnityEngine.Random.Range(min, max + 1);
    }

    void setView(int value)
    {
        guessText.text = value.ToString();
    }

    void restartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
    }
}
