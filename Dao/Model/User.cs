using Dapper;
using System;


namespace Dao.Model
{
    [Table("SysUser")]
    public class SysUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserNo { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
