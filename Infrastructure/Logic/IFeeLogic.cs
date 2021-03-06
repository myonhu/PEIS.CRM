﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logic
{
    public interface IFeeLogic
    {
        IEnumerable<OnCustFee> GetFeeDetailForCustomerId(long customerId);
        double getExamPrice(OnCustPhysicalExamInfo info);
    }
}
