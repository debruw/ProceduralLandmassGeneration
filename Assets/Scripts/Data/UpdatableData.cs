using UnityEngine;

[CreateAssetMenu()]
public class UpdatableData : ScriptableObject
{
    public event System.Action OnValuesUpdated;
    public bool autoupdate;

    protected virtual void OnValidate()
    {
        if (autoupdate)
        {
            NotifyOfUpdatedValues();
        }
    }

    public void NotifyOfUpdatedValues()
    {
        if (OnValuesUpdated != null)
        {
            OnValuesUpdated.Invoke();
        }
    }
}