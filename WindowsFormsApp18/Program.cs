﻿/****************************************************************************
**                          SAKARYA ÜNİVERSİTESİ
**               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                    NESNEYE DAYALI PROGRAMLAMA DERSİ
**                         2019-2020 BAHAR DÖNEMİ
**
**                     PROJE NUMARASI.........:2-Proje
**                     ÖĞRENCİ ADI............: ESSRAA BAKR
**                     ÖĞRENCİ NUMARASI.......: B181200552
**                     DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp18.Properties;

namespace WindowsFormsApp18
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new kayıt());
        }
    }
}
