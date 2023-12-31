﻿using PracticalCore20.Interfaces;
using PracticalCore20.Models;

namespace PracticalCore20.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private IStudentRepository _studentRepository;


        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IStudentRepository StudentRepository
        {
            get { return _studentRepository = _studentRepository ?? new StudentRepository(_dbContext); }
        }

        public void Commit()
            => _dbContext.SaveChanges();

        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Dispose();

        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}
