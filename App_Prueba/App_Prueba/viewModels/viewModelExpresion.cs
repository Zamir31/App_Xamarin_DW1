using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using App_Prueba.Models;

namespace App_Prueba.viewModels
{
    public class viewModelExpresion : INotifyPropertyChanged
    {
        private int num1;
        private int num2;
        private string msj;

        public viewModelExpresion() {
            sumar = new Command(() =>
            {
                Expresion expresion = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };
                Msj = expresion.sumar();
            });

            restar = new Command(() =>
            {
                Expresion expresion = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };
                Msj = expresion.restar();
            });

            multiplicar = new Command(() =>
            {
                Expresion expresion = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };
                Msj = expresion.multiplicar();
            });

            dividir = new Command(() =>
            {
                Expresion expresion = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2,
                };
                Msj = expresion.dividir();
            });
        }


        public string Msj
        {
            get => msj;
            set
            {
                msj = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(Msj));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }
        public int Num1
        {
            get => num1;
            set
            {
                num1 = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }

        public int Num2
        {
            get => num2;
            set
            {
                num2 = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }

        public Command sumar { get; }
        public Command restar { get; }
        public Command multiplicar { get; }
        public Command dividir { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
