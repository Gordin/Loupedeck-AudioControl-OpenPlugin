﻿namespace WindowsCoreAudio
{
    using System.Runtime.InteropServices;

    using WindowsCoreAudio.API;

    public class AudioEndpointVolumeChannels
    {
        private readonly IAudioEndpointVolume audioEndPointVolume;
        private readonly AudioEndpointVolumeChannel[] channels;

        public int Count
        {
            get
            {
                Marshal.ThrowExceptionForHR(this.audioEndPointVolume.GetChannelCount(out int channelCount));
                return channelCount;
            }
        }

        /// <summary>
        /// Indexer - get a specific channel
        /// </summary>
        public AudioEndpointVolumeChannel this[int index] => this.channels[index];

        internal AudioEndpointVolumeChannels(IAudioEndpointVolume parent)
        {
            this.audioEndPointVolume = parent;
            int channelCount = this.Count;
            this.channels = new AudioEndpointVolumeChannel[channelCount];
            for (int i = 0; i < channelCount; i++)
            {
                this.channels[i] = new AudioEndpointVolumeChannel(this.audioEndPointVolume, i);
            }
        }

    }
}
