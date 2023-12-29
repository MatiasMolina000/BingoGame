﻿using APIBingo.Datas;
using APIBingo.Models;
using APIBingo.Models.Request;
using APIBingo.Models.Response;
using APIBingo.Services.Connection;

namespace APIBingo.Rules
{
    public class UserRule
    {
        private readonly IDBFactoryConnection _connectionFactory;


        public UserRule(IDBFactoryConnection connectionFactory) => _connectionFactory = connectionFactory;


        public async Task<ResultResponse<UserRequest>> New(UserRequest oModel)
        {
            ResultResponse<UserRequest> response = new() { Data = oModel };

            var exist = await new UserData(_connectionFactory).CheckByUserOrEmail(oModel);
            if (exist)
            {
                response.Message = "The user or email already exist.";
            }
            else 
            {
                Random rnd = new();
                int rndNum = rnd.Next(1000, 1000000);

                UserModel oUser = new()
                {
                    User = oModel.User,
                    Email = oModel.Email,
                    Password = oModel.Password,
                    PassTemp = rndNum.ToString(),
                };
                var add = await new UserData(_connectionFactory).New(oUser);
                if (add != null)
                {
                    response.Message = add;
                }
                response.Success = true;
            }

            return response;
        }
    }
}