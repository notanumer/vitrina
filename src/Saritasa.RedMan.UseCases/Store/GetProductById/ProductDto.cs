﻿using Saritasa.RedMan.Domain.Store;
using Saritasa.RedMan.UseCases.Users.Common.Dtos;

namespace Saritasa.RedMan.UseCases.Store.GetProductById;

/// <summary>
/// Product DTO.
/// </summary>
public class ProductDto
{
    /// <inheritdoc cref="Product.Id"/>
    public int Id { get; set; }

    /// <inheritdoc cref="Product.Name"/>
    required public string Name { get; set; }

    /// <inheritdoc cref="Product.Sku"/>
    required public string Sku { get; set; }

    /// <inheritdoc cref="Product.Status"/>
    public ProductStatus Status { get; set; }

    /// <inheritdoc cref="Product.CreatedByUser"/>
    required public UserDto CreatedByUser { get; set; }
}
