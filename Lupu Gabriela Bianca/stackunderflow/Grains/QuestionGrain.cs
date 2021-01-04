using System;
using System.Collections.Generic;
using System.Text;
using StackUnderflow.EF.Models;

namespace Grains
{
  public  class QuestionGrain
    {

        private readonly StackUnderflowContext _dbContext;

        public QuestionGrain(StackUnderflowContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
