﻿/*
 * Copyright 2011 Xamarin, Inc & Christopher Gooley
 *
 * Author(s):
 * 	Gonzalo Paniagua Javier (gonzalo@xamarin.com)
 *  Christopher Gooley / FolioHD (gooley@foliohd.com)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using Newtonsoft.Json;

namespace Xamarin.Payments.Stripe {
    [JsonObject (MemberSerialization.OptIn)]
    public class StripeCustomer {
        [JsonProperty (PropertyName = "livemode")]
        public bool LiveMode { get; set; }
        [JsonProperty (PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty (PropertyName = "created")]
        [JsonConverter (typeof (UnixDateTimeConverter))]
        public DateTime? Created { get; set; }
        [JsonProperty (PropertyName = "id")]
        public string ID { get; set; }
        [JsonProperty (PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty (PropertyName = "active_card")]
        public StripeCard Card { get; set; }

        [JsonProperty(PropertyName = "subscription")]
        public StripeSubscription Subscription { get; set; }

        [JsonProperty(PropertyName = "next_recurring_charge")]
        public StripeNextRecurringCharge NextRecurringCharge { get; set; }
    }
}
