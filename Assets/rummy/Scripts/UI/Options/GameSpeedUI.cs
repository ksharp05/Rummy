using UnityEngine;
using UnityEngine.UI;
using rummy.Utility;

namespace rummy.UI.Options
{
    [RequireComponent(typeof(Text))]
    public class GameSpeedUI : MonoBehaviour
    {
        private Text text;

        private void Start()
        {
            text = GetComponent<Text>();
        }

        private void Update()
        {
            text.text = Tb.I.GameMaster.GameSpeed.ToString("0.00");
        }
    }

}