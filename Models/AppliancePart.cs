// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using Microsoft.Graph;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsInventoryConnector.Models
{
    public class AppliancePart
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public Properties AsExternalItemProperties()
        {
            var properties = new Properties
            {
                AdditionalData = new Dictionary<string, object>
                {
                    { "Id", Id },
                    { "Url", Url },
                    { "Text", Text },
                    { "Title", Title },
                }
            };

            return properties;
        }
    }
}