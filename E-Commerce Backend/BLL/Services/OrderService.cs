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
    public class OrderService
    {
        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrderDTO>>(data);
            return mapped;
        }

        public static OrderDTO Get(int id)
        {
            var data = DataAccessFactory.OrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDTO>(data);
            return mapped;
        }

        public static bool Add(OrderDTO Orderdto)
        {

            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDTO, Order>();
            });
            var mapper2 = new Mapper(cfg2);

            Order Order = mapper2.Map<Order>(Orderdto);

            return DataAccessFactory.OrderData().Create(Order);
        }

        public static bool Update(OrderDTO Orderdto)
        {

            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDTO, Order>();
            });
            var mapper2 = new Mapper(cfg2);

            Order Order = mapper2.Map<Order>(Orderdto);

            return DataAccessFactory.OrderData().Update(Order);

            
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderData().Delete(id);
        }
    }
}
