using UnityEngine;

[CreateAssetMenu]
public class Conversation : ScriptableObject
{
  [SerializeField] private DialogueLine[] allLines;

  public DialogueLine GetLineByIndex(int index)
  {
    return allLines[index];
  }

  public int GetLength()
  {
    return allLines.Length - 1;
  }
}
