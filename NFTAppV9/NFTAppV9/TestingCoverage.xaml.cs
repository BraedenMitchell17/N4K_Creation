﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NFTAppV9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestingCoverage : ContentPage
    {
        //public Command TouchCommand { get; }
        //Timer timer = new Timer();
        //Timer masterTimer = new Timer();
        //int counter;
        //int masterCounter;
        //bool pressed = true;
        //public Android.Views.MotionEvent.PointerCoords pointerCoords1 { get; set; }
        //int pointerIndex = 0;
        //float y;
        ////float x;
        ////int outPointerCoords;
        //GestureRecognizer g = new GestureRecognizer();
        //public MotionEvent pointerCoords { get; }

        public TestingCoverage(string location)
        {
            InitializeComponent();

            //pointerCoords = new MotionEvent();
            //pointerCoords.GetAxisValue(Axis.RelativeX);

            //Master timer for the synthetic pressure data metric
            //Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
            //{
            //    masterCounter++;



            //    if(pressed == false)
            //    {
            //        int timeMaster = masterCounter;
            //        return false;
            //    }

            //    return true;
            //});
        }

        //private void KissTest_Pressed(object sender, EventArgs e)
        //{
        //    //x = pointerCoords.X;
        //    //pointerCoords.Y = y;
        //    //pointerCoords.GetAxisValue(Android.Views.Axis.X);
        //    //System.Console.WriteLine("DEBUG - " + pointerCoords.GetAxisValue(Android.Views.Axis.X));
        //    //pointerCoords.GetPointerCoords(0, MotionEvent.PointerCoords outPointerCoords);

        //    //KissTest.BackgroundColor = Color.Red;
        //    //pressed = true;
        //    Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
        //    {
        //        if (pressed == true)
        //        {
        //            //System.Console.WriteLine("DEBUG - KissTest Pressed!");
        //            counter++;
        //            //lblDuration.Text = counter.ToString();

        //            //System.Console.WriteLine(x = pointerCoords.Pressure);

        //            return true;
        //        }
        //        else
        //        {
        //            //System.Console.WriteLine("DEBUG - KissTest Released!");
        //            //File.WriteAllLines("NFT.txt", lblDuration.Text);
        //            return false;
        //        }
        //    });
        //}

        //private void KissTest_Released(object sender, EventArgs e)
        //{
        //    pressed = false;
        //}

        //Android.Views.View.TouchEventArgs touch { get; set; }
        //public MotionEvent ev { get; set; }
        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    //touch.Event.GetRawX(pointerIndex);
        //    //float x = MotionEvent.GetX(pointerIndex);

        //    float x = ev.GetX();
        //}

        //public bool OnTouch(Android.Views.View v, MotionEvent e)
        //{
        //    float Xaxis = e.GetX();
        //    float Yaxis = e.GetY();
        //    return false;
        //}
    }
}