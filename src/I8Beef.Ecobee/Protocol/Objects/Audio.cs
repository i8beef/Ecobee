using System.Collections.Generic;
using Newtonsoft.Json;

namespace I8Beef.Ecobee.Protocol.Objects
{
    /// <summary>
    /// Ecobee API Audio.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Audio
    {
        /// <summary>
        /// The volume level for audio playback. This includes volume of the voice
        /// assistant. A value between 0 and 100.
        /// </summary>
        [JsonProperty(PropertyName = "playbackVolume")]
        public int? PlaybackVolume { get; set; }

        /// <summary>
        /// Turn microphone (privacy mode) on and off.
        /// </summary>
        [JsonProperty(PropertyName = "microphoneEnabled	")]
        public bool? MicrophoneEnabled { get; set; }

        /// <summary>
        /// The volume level for alerts on the thermostat. A value between 0 and 10, with 0
        /// meaning 'off' - the zero value may not be honored by all ecobee versions.
        /// </summary>
        [JsonProperty(PropertyName = "soundAlertVolume")]
        public int? SoundAlertVolume { get; set; }

        /// <summary>
        /// The volume level for key presses on the thermostat. A value between 0 and 10,
        /// with 0 meaning 'off' - the zero value may not be honored by all ecobee versions.
        /// </summary>
        [JsonProperty(PropertyName = "soundTickVolume")]
        public int? SoundTickVolume { get; set; }

        /// <summary>
        /// The list of voice engines compatible with the selected thermostat.
        /// </summary>
        [JsonProperty(PropertyName = "voiceEngines")]
        public IList<VoiceEngine> VoiceEngines { get; set; }
    }
}
