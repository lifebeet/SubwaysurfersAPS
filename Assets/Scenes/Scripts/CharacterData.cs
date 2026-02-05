using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string jumpAnimationName = "Jump";
    public string moveAnimationName = "Move";
    public string rollAnimationName = "roll";
    public string loseAntimationName = "Lose";
    public string runAnimationName = "run";
    
    }



