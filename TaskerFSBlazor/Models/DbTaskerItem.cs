using TaskerFSBlazor.Data;
using TaskerFSBlazor.Client.Models;
using System.ComponentModel.DataAnnotations;

namespace TaskerFSBlazor.Models
{
    public class DbTaskerItem : TaskerItem
    {
        [Required]
        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }
    }
}