using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
    }
}
