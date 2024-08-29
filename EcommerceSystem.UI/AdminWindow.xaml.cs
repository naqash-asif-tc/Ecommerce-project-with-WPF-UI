﻿using System.Windows;
using EcommerceSystem.Core.Services;
namespace EcommerceSystem.UI
{
    public partial class AdminWindow : Window
    {
        private readonly IProductService _productService;

        public AdminWindow(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            var addProductWindow = new AddProductWindow(_productService);
            addProductWindow.Show();
        }

        private void ViewProducts_Click(object sender, RoutedEventArgs e)
        {
            var viewProductsWindow = new ViewProductsWindow(_productService);
            viewProductsWindow.Show();
        }

        private void UpdateProduct_Click(object sender, RoutedEventArgs e)
        {
            var updateProductWindow = new UpdateProductWindow(_productService);
            updateProductWindow.Show();
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
           var deleteProductWindow = new DeleteProductWindow(_productService);
           deleteProductWindow.Show();
        }
    }
}
