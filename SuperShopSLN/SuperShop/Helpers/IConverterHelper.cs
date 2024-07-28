﻿using SuperShop.Data.Entities;
using SuperShop.Models;

namespace SuperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool inNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}
