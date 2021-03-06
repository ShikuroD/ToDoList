using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AppCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcClient.Models
{
    public class LogViewModel
    {
        public PaginatedList<DbLog> Logs { get; set; }
        public SelectList userIds { get; set; }
        public SelectList taskIds { get; set; }
        public SelectList userNames { get; set; }
    }
    public enum LOG_SEARCH
    {

        //FOR LOG
        [Display(Name = "Ngày thực hiện")]
        EXEC_DATE,
        [Display(Name = "Tên công việc")]
        TASK_NAME,
        [Display(Name = "Người thực hiện")]
        EXEC_USER_NAME,
        [Display(Name = "ID công việc")]
        TASK_ID,
        [Display(Name = "ID người thực hiện")]
        EXEC_USER_ID,
        [Display(Name = "Hành động")]
        ACTION
    }

}