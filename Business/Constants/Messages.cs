using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //Public'ler büyük harfle yazılır. Eğer class'ın içinde bir field tanımlsaydık küçük harfle başlyacaktık. Pascal Case
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductsListedOutHours = "Ürünler saat sebebiyle listelenemedi";

    }
}
