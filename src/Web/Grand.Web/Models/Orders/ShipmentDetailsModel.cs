﻿using Grand.Infrastructure.Models;
using Grand.Web.Models.Common;

namespace Grand.Web.Models.Orders
{
    public class ShipmentDetailsModel : BaseEntityModel
    {
        public int ShipmentNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingNumberUrl { get; set; }
        public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public IList<ShipmentStatusEventModel> ShipmentStatusEvents { get; set; } = new List<ShipmentStatusEventModel>();
        public bool ShowSku { get; set; }
        public IList<ShipmentItemModel> Items { get; set; } = new List<ShipmentItemModel>();
        public IList<ShipmentNote> ShipmentNotes { get; set; } = new List<ShipmentNote>();
        public OrderModel Order { get; set; }

		#region Nested Classes

        public class ShipmentItemModel : BaseEntityModel
        {
            public string Sku { get; set; }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductSeName { get; set; }
            public string AttributeInfo { get; set; }
            public string RentalInfo { get; set; }

            public int QuantityOrdered { get; set; }
            public int QuantityShipped { get; set; }
        }

        public class ShipmentStatusEventModel : BaseModel
        {
            public string EventName { get; set; }
            public string Location { get; set; }
            public string Country { get; set; }
            public DateTime? Date { get; set; }
        }
        public class ShipmentNote : BaseEntityModel
        {
            public bool HasDownload { get; set; }
            public string Note { get; set; }
            public DateTime CreatedOn { get; set; }
            public string ShipmentId { get; set; }
        }
        public class OrderModel : BaseEntityModel
        {
            public int OrderNumber { get; set; }
            public string OrderCode { get; set; }
            public string ShippingMethod { get; set; }
            public bool PickUpInStore { get; set; }
            public AddressModel PickupAddress { get; set; }
            public AddressModel ShippingAddress { get; set; }
        }
        #endregion
    }
}