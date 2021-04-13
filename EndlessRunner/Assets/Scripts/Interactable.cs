using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool IsInteractable { get; private set; }

    public bool SetInteractable(bool interactable) => IsInteractable = interactable;

}
