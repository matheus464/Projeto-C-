using System;


namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException // herança 
    {
        public NotFoundException(string message) : base(message) 
        { 
        }
       
    }
}
