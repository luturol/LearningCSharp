using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
   private bool isInteractable;

   public bool SetInteractable(bool interactable) => isInteractable = interactable;
   
}
