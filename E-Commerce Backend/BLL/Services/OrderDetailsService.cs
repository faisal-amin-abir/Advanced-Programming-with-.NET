using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderDetailsService
    {
        public static List<OrderDetailsDTO> Get()
        {
            var data = DataAccessFactory.OrderDetailsData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrderDetailsDTO>>(data);
            return mapped;
        }

        public static OrderDetailsDTO Get(int id)
        {
            var data = DataAccessFactory.OrderDetailsData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDetailsDTO>(data);
            return mapped;
        }

        public static bool Add(OrderDetailsDTO OrderDetailsdto)
        {

            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailsDTO, OrderDetails>();
            });
            var mapper2 = new Mapper(cfg2);

            OrderDetails OrderDetails = mapper2.Map<OrderDetails>(OrderDetailsdto);

            return DataAccessFactory.OrderDetailsData().Create(OrderDetails);
        }


        public static bool Update(OrderDetailsDTO OrderDetailsdto)
        {

            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailsDTO, OrderDetails>();
            });
            var mapper2 = new Mapper(cfg2);

            OrderDetails OrderDetails = mapper2.Map<OrderDetails>(OrderDetailsdto);

            return DataAccessFactory.OrderDetailsData().Update(OrderDetails);


        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderDetailsData().Delete(id);
        }
    }
}
