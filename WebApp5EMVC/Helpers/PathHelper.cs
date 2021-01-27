using System;
using WebApp5EMVC.Models.Entity;

namespace WebApp5EMVC.Helpers
{
    public static class PathHelper
    {
        private static string _uploadspath;
        private static string _imgprodottopath;

        public static void InitPaths(string up, string ipp)
        {
            _uploadspath = up;
            _imgprodottopath = ipp;
        }

        public static string GetProdottoImagePath(Prodotto prodotto)
        {
            return $"{_uploadspath}{_imgprodottopath}/{prodotto.Id}/{prodotto.Immagine}";
        }

        public static string GetProdottoUrl(int id)
        {
            return $"/home/detail/{id}";
        }
    }
}
