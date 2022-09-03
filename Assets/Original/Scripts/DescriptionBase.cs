using UnityEngine;

namespace SO.Events
{
    public abstract class DescriptionBase : ScriptableObject
    {
        [TextArea]
        [SerializeField]
        private string description;
    }
}