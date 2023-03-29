using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Event Dispatchers
    public delegate void Vector2InputEvent(Vector2 direction);

    public static Vector2InputEvent MoveEvent;

    public delegate void ButtonInputEvent(ButtonInputContext context);

    public static ButtonInputEvent JumpButtonPressed;
    #endregion

    public static InputManager instance;

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

    }
}

[System.Serializable]
public struct ButtonInputContext
{

}
