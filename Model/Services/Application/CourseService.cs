using System;
using System.Collections.Generic;
using WebApp1.Model.ViewModels;

namespace WebApp1.Model.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetServices()
        {
            var listaCorsi = new List<CourseViewModel>();
            var prezzoArbit = new Random();
            for(int i = 1; i<=5; i++){
                var corso = new CourseViewModel{
                    Id = i,
                    NomeCorso = "Corso n. {0}" + i,
                    Price = prezzoArbit.NextDouble() * 10 + 10,
                    PathImg = "C:/Users/Daniel Ray/Desktop/Progetti e Varie/Icone/c-sharp-c-logo-02F17714BA.ico"
                };
                listaCorsi.Add(corso);
            }
            return listaCorsi;
        }
    }
}