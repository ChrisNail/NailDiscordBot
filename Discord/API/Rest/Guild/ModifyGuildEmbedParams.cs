﻿using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * 
     */
    public class ModifyGuildEmbedParams {

        /**
         * Enabled
         */
        [JsonProperty("enabled")]
        public bool? enabled;

        /**
         * Snowflake Channel ID for embed Channel.
         */
        [JsonProperty("channel_id")]
        public string channelId;
    }
}
