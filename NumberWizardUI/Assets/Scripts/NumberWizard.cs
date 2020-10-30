using TMPro;
using UnityEngine;

namespace NumberWizard
{
    public class NumberWizard : MonoBehaviour
    {
        [SerializeField] private int _min;
        [SerializeField] private int _max;
        [SerializeField] private TextMeshProUGUI _guessText;

        private int _guess;

        // Start is called before the first frame update
        private void Start()
        {
            StartGame();
        }

        private void StartGame()
        {
            NextGuess();
        }

        private void NextGuess()
        {
            _guess = Random.Range(_min, _max + 1);
            _guessText.text = _guess.ToString();
        }

        public void OnPressHigher()
        {
            _min = _guess + 1;
            NextGuess();
        }

        public void OnPressLower()
        {
            _max = _guess - 1;
            NextGuess();
        }
    }
}
