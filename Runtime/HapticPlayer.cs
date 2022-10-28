using UnityEngine;

using Lofelt.NiceVibrations;

namespace TalusHaptic
{
    [CreateAssetMenu]
    public class HapticPlayer : ScriptableObject
    {
        public HapticPatterns.PresetType Preset;

        public void Play()
        {
            HapticPatterns.PlayPreset(Preset);
        }
    }
}