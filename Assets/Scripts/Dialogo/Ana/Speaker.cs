using UnityEngine;

[CreateAssetMenu]
public class Speaker : ScriptableObject
{
  [SerializeField] private string speakerName;
  [SerializeField] private Sprite speakerSprite;

  public string GetName()
  {
    return speakerName;
  }

  public Sprite GetSprite()
  {
    return speakerSprite;
  }
}
