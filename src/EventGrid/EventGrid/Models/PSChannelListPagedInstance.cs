﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.EventGrid.Models;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.EventGrid.Models
{
    public class PSChannelListPagedInstance
    {
        public List<PSChannelListInstance> PsChannelsList = new List<PSChannelListInstance>();
        public string NextLink;

        public PSChannelListPagedInstance(IEnumerable<Channel> channelsList, string nextLink)
        {
            foreach (Channel channel in channelsList)
            {
                this.PsChannelsList.Add(new PSChannelListInstance(channel));
            }

            this.NextLink = nextLink;
        }
    }
}
