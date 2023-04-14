using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public void Click()
    {
        AudioManager.Instance.PlayButtonClick();
    }
}
