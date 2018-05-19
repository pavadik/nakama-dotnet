﻿/**
 * Copyright 2018 The Nakama Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Nakama
{
    public interface IMatchState
    {
        /// <summary>
        /// The unique match identifier.
        /// </summary>
        string MatchId { get; }

        /// <summary>
        /// The operation code for the state change.
        /// </summary>
        /// <remarks>
        /// This value can be used to mark the type of the contents of the state.
        /// </remarks>
        long OpCode { get; }

        /// <summary>
        /// The byte contents of the state change.
        /// </summary>
        byte[] State { get; }

        /// <summary>
        /// Information on the user who sent the state change.
        /// </summary>
        IUserPresence UserPresence { get; }
    }
}
