﻿// <copyright file="ButtplugConnectorJSONParser.cs" company="Nonpolynomial Labs LLC">
// Buttplug C# Source Code File - Visit https://buttplug.io for more info about the project.
// Copyright (c) Nonpolynomial Labs LLC. All rights reserved.
// Licensed under the BSD 3-Clause license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using Robust.Buttplug.Core;
using Robust.Buttplug.Core.Messages;

namespace Robust.Buttplug.Client
{
    // ReSharper disable once InconsistentNaming
    public class ButtplugConnectorJSONParser
    {
        /// <summary>
        /// Used for converting messages between JSON and Objects.
        /// </summary>
        private readonly ButtplugJsonMessageParser _parser = new ButtplugJsonMessageParser();

        /// <summary>
        /// Converts a single <see cref="ButtplugMessage"/> into a JSON string.
        /// </summary>
        /// <param name="msg">Message to convert.</param>
        /// <returns>The JSON string representation of the message.</returns>
        public string Serialize(ButtplugMessage msg)
        {
            return _parser.Serialize(msg);
        }

        /// <summary>
        /// Converts an array of <see cref="ButtplugMessage"/> into a JSON string.
        /// </summary>
        /// <param name="msgs">An array of messages to convert.</param>
        /// <returns>The JSON string representation of the messages.</returns>
        public string Serialize(ButtplugMessage[] msgs)
        {
            return _parser.Serialize(msgs);
        }

        /// <summary>
        /// Converts a JSON string into an array of <see cref="ButtplugMessage"/>.
        /// </summary>
        /// <param name="msg">A JSON string representing one or more messages.</param>
        /// <returns>An array of <see cref="ButtplugMessage"/>.</returns>
        public IEnumerable<ButtplugMessage> Deserialize(string msg)
        {
            return _parser.Deserialize(msg);
        }
    }
}