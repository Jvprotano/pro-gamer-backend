﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ProGamer.BackEnd.Models.Request
{
    public class RegisterCourseRequest
    {
        [Required(ErrorMessage = "O campo título é obrigatório.")]
        [JsonProperty("title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        [JsonProperty("description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo duração é obrigatório.")]
        [JsonProperty("duration")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório.")]
        [JsonProperty("value")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "O campo jogo é obrigatório.")]
        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

}