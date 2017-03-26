using mg.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ng.api.Controllers
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        /// <summary>
        /// 登陆成功和失败
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpGet]
        public bool Login(string email, string password)
        {
            var user = new User() { Email = email, Password = password };

            return userList.Exists(x => x.Email == user.Email.ToLower() && x.Password == user.Password);
        }

        /// <summary>
        /// 获取邮箱列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetEmailList()
        {
            return userList.Select(x => x.Email).ToList();
        }

        public static List<User> userList = new List<User>() {
            new User() { Email = "344913393@qq.com", Password = "11111111" },
            new User() { Email = "leedan1130@163.com", Password = "66666666" },
            new User() { Email = "leehuohuo@yeah.com", Password = "88888888" },
        };
    }
}