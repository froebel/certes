﻿using Newtonsoft.Json;

namespace Certes.Jws
{
    /// <summary>
    /// Represents a JWK using Elliptic Curve.
    /// </summary>
    /// <seealso cref="Certes.Jws.JsonWebKey" />
    internal class EcJsonWebKey : JsonWebKey
    {
        /// <summary>
        /// Gets or sets the curve identifies the cryptographic curve used with the key.
        /// </summary>
        /// <value>
        /// The curve identifies the cryptographic curve used with the key.
        /// </value>
        [JsonProperty("crv")]
        internal string Curve { get; set; }

        /// <summary>
        /// Gets or sets the x coordinate for the Elliptic Curve point.
        /// </summary>
        /// <value>
        /// The x coordinate for the Elliptic Curve point.
        /// </value>
        [JsonProperty("x")]
        internal string X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate for the Elliptic Curve point.
        /// </summary>
        /// <value>
        /// The y coordinate for the Elliptic Curve point.
        /// </value>
        [JsonProperty("y")]
        internal string Y { get; set; }
    }
}
