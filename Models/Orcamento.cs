using System;

namespace SelectListEmCascata.Models 
{
    public class Orcamento
    {
        public int Id { get; set; }        
        public double Total { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        
    }
}