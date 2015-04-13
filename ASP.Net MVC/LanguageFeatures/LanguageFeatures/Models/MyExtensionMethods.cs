using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models {
    public static class MyExtensionMethods {

        public static decimal TotalPrices(this ShoppingCart cartParam) {
            decimal total = 0;
            foreach (Product product in cartParam.Products) {
                total += product.Price;
            }

            return total;
        }

        public static decimal TotalPrices(this IEnumerable<Product> productEnum) {
            decimal total = 0;
            foreach (Product product in productEnum) {
                total += product.Price;
            }

            return total;
        }

        public static IEnumerable<Product> FilterByCategory(
            this IEnumerable<Product> productEnum, string categoryParam) {

                foreach (Product product in productEnum) {
                    if (product.Category == categoryParam) {
                        yield return product;
                    }
                }
        }
    }
}