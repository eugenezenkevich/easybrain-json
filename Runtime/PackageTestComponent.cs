using UnityEngine;
using UnityEngine.UI;

namespace Easybrain.Json
{
    public class PackageTestComponent: MonoBehaviour
    {
        [SerializeField] private Text _text;
        [SerializeField] private Button _button;

        void Start()
        {
            _text.text = "Everything works";
            _button.onClick.AddListener(() =>
            {
                _text.text = "ButtonClicked";
            });
        }
        
    }
}
