﻿using Microsoft.EntityFrameworkCore;
using GeekShopping.OrderAPI.Models;
using GeekShopping.OrderAPI.Data;

namespace GeekShopping.OrderAPI.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbContextOptions<ApplicationDbContext> _context;

        public OrderRepository(DbContextOptions<ApplicationDbContext> context)
        {
            _context = context;
        }

        public async Task<bool> AddOrder(OrderHeader header)
        {
            if (header == null) return false;

            await using var _database = new ApplicationDbContext(_context);
            _database.Headers.Add(header);
            await _database.SaveChangesAsync();
            return true;
        }

        public async Task UpdateOrderPaymentStatus(long orderHeaderId, bool status)
        {
            await using var _database = new ApplicationDbContext(_context);
            var header = await _database.Headers.FirstOrDefaultAsync(o => o.Id == orderHeaderId);
            
            if (header != null) {
                header.PaymentStatus = status;
                await _database.SaveChangesAsync();
            };
        }
    }
}