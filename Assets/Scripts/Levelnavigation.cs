using UnityEngine;
using UnityEngine.SceneManagement;
public class Levelnavigation : MonoBehaviour
{
    [SerializeField] public string gotoscene;
    public void LoadScene()
    {
        SceneManager.LoadScene(gotoscene);
    }
}
