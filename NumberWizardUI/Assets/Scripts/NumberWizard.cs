using UnityEngine;

namespace NumberWizard
{
    public class NumberWizard : MonoBehaviour
    {
        [SerializeField] private int _min;
        [SerializeField] private int _max;
        private int _guess;

        // Start is called before the first frame update
        private void Start()
        {
            StartGame();
        }

        private void StartGame()
        {
            _max++;
            _guess = (_max + _min) / 2;
        }

        private void NextGuess()
        {
            _guess = (_max + _min) / 2;
        }

        public void OnPressHigher()
        {
            _min = _guess;
            NextGuess();
        }

        public void OnPressLower()
        {
            _max = _guess;
            NextGuess();
        }
    }
}
