using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] string OnLoseJumpTo = "End";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (OnLoseJumpTo != null)
        {
            SceneManager.LoadScene(OnLoseJumpTo);
        }
    }
}
