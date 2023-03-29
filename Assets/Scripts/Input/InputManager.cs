using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Event Dispatchers
    public delegate void ButtonInputEvent(ButtonInputContext context);

    public static ButtonInputEvent JumpButtonPressed;
    #endregion

    public static InputManager instance;

    public static Vector2 MoveInput = Vector2.zero;

    #region Init Functions
    private void Awake()
    {
        if(instance != this && instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion

    private void Update()
    {
        //poll for inputs

        CheckMoveInput();

    }

    private void CheckMoveInput()
    {
        MoveInput.x = Input.GetAxis("Horizontal");
        MoveInput.y = Input.GetAxis("Vertical");
    }
}

[System.Serializable]
public struct ButtonInputContext
{

}
