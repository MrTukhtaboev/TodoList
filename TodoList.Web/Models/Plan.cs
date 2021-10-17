using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Web.Models
{
    public class Plan
    {
        public int Id {  get; set; }
        public string Title {  get; set; }
        public DateTime DateTime { get; set; }
        public string Description {  get; set; }
    }
}
