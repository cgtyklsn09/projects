using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Fees
    {
        private string grade;
        private double osmangazi;
        private double yss;
        private double fsm;
        private double anadolu;
        private double izmir_aydin;
        private double cukurova;
        private double nmanatolian;
        private double nmeuropean;
        private double gebze_orhangazi_izmir;

        public string Grade { get => grade; set => grade = value; }
        public double Osmangazi { get => osmangazi; set => osmangazi = value; }
        public double Yss { get => yss; set => yss = value; }
        public double Fsm { get => fsm; set => fsm = value; }
        public double Anadolu { get => anadolu; set => anadolu = value; }
        public double Izmir_aydin { get => izmir_aydin; set => izmir_aydin = value; }
        public double Cukurova { get => cukurova; set => cukurova = value; }
        public double Nmanatolian { get => nmanatolian; set => nmanatolian = value; }
        public double Nmeuropean { get => nmeuropean; set => nmeuropean = value; }
        public double Gebze_orhangazi_izmir { get => gebze_orhangazi_izmir; set => gebze_orhangazi_izmir = value; }
    }
}
