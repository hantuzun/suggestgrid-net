/*
 * SuggestGrid.PCL
 *
 * This file was automatically generated for SuggestGrid by APIMATIC v2.0 ( https://apimatic.io ) on 01/20/2017
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SuggestGrid;

namespace SuggestGrid.Models
{
    public class GetRecommendedItemsBody : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string type;
        private string types;
        private string userId;
        private List<string> userIds;
        private int? mfrom;
        private int? size;
        private string similarItemId;
        private string similarItemIds;
        private List<string> fields;
        private object filter;
        private List<string> except;

        /// <summary>
        /// The type of the query.
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The types of the query. Exactly one of type or types parameters must be provided.
        /// </summary>
        [JsonProperty("types")]
        public string Types 
        { 
            get 
            {
                return this.types; 
            } 
            set 
            {
                this.types = value;
                onPropertyChanged("Types");
            }
        }

        /// <summary>
        /// The user id of the query.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId 
        { 
            get 
            {
                return this.userId; 
            } 
            set 
            {
                this.userId = value;
                onPropertyChanged("UserId");
            }
        }

        /// <summary>
        /// The user ids of the query. Exactly one of user id or user ids parameters must be provided.
        /// </summary>
        [JsonProperty("user_ids")]
        public List<string> UserIds 
        { 
            get 
            {
                return this.userIds; 
            } 
            set 
            {
                this.userIds = value;
                onPropertyChanged("UserIds");
            }
        }

        /// <summary>
        /// The number of most recommended items to be skipped.
        /// </summary>
        [JsonProperty("from")]
        public int? From 
        { 
            get 
            {
                return this.mfrom; 
            } 
            set 
            {
                this.mfrom = value;
                onPropertyChanged("From");
            }
        }

        /// <summary>
        /// The number of items asked to return in the response.
        /// </summary>
        [JsonProperty("size")]
        public int? Size 
        { 
            get 
            {
                return this.size; 
            } 
            set 
            {
                this.size = value;
                onPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Similar item that the response should be similar to.
        /// </summary>
        [JsonProperty("similar_item_id")]
        public string SimilarItemId 
        { 
            get 
            {
                return this.similarItemId; 
            } 
            set 
            {
                this.similarItemId = value;
                onPropertyChanged("SimilarItemId");
            }
        }

        /// <summary>
        /// Similar items that the response should be similar to.
        /// At most one of similar item and similar items parameters can be provided.
        /// </summary>
        [JsonProperty("similar_item_ids")]
        public string SimilarItemIds 
        { 
            get 
            {
                return this.similarItemIds; 
            } 
            set 
            {
                this.similarItemIds = value;
                onPropertyChanged("SimilarItemIds");
            }
        }

        /// <summary>
        /// The metadata fields to be included in returned item objects.
        /// </summary>
        [JsonProperty("fields")]
        public List<string> Fields 
        { 
            get 
            {
                return this.fields; 
            } 
            set 
            {
                this.fields = value;
                onPropertyChanged("Fields");
            }
        }

        /// <summary>
        /// Contraints on the returned users or items.
        /// Filter structure is defined in [the filter parameter documentation](http://www.suggestgrid.com/docs/advanced-features#filters-parameter).
        /// </summary>
        [JsonProperty("filter")]
        public object Filter 
        { 
            get 
            {
                return this.filter; 
            } 
            set 
            {
                this.filter = value;
                onPropertyChanged("Filter");
            }
        }

        /// <summary>
        /// These item ids that will not be included in the response.
        /// </summary>
        [JsonProperty("except")]
        public List<string> Except 
        { 
            get 
            {
                return this.except; 
            } 
            set 
            {
                this.except = value;
                onPropertyChanged("Except");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 