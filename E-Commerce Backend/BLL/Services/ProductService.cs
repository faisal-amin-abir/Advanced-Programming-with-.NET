using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }

        public static ProductDTO Get(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }

        public static ProductDTO Add(ProductDTO productdto)
        {

            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper2 = new Mapper(cfg2);

            Product product = mapper2.Map<Product>(productdto);

            var data = DataAccessFactory.ProductData().Create(product);

            if (data == null) return null;

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }

        public static ProductDTO Update(ProductDTO productdto)
        {

            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper2 = new Mapper(cfg2);

            Product product = mapper2.Map<Product>(productdto);

            var data = DataAccessFactory.ProductData().Update(product);

            if (data == null) return null;

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ProductData().Delete(id);
        }
    }
}
