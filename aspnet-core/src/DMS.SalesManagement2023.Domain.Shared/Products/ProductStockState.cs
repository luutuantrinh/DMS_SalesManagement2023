using System;
using System.Collections.Generic;
using System.Text;

namespace DMS.SalesManagement2023.Products
{
    public enum ProductStockState : byte
    {
        PreOrder,
        InStock,
        NotAvailable,
        Stopped
    }
}
