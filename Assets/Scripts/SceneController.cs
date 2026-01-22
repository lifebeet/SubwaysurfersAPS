 using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private Animator fade;
    [SerializeField]
    private string fadeAnimationName;

    public void GotoSceneWithFade(string SceneName)
    {
        StartCoroutine(LoadSceneAfterFade(SceneName));
    }

  private IEnumerator LoadSceneAfterFade(string SceneName)
    {
        fade.Play(fadeAnimationName,0,0f);
        yield return new WaitForSeconds(fade.GetCurrentAnimatorStateInfo(0).length);
        SceneManager.LoadScene(SceneName);
    }
        
    }

