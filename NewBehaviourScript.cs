using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject targetObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Замените KeyCode.Space на желаемую клавишу
        {
            if (targetObject.activeSelf)
            {
                targetObject.SetActive(false);
            }
            else
            {
                targetObject.SetActive(true);
            }
        }
    }
}