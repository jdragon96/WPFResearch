using CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFCoreResearch
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            SliderOnOffCommand = new ValidationCommand<bool>(ExecuteValidation);
            SliderStateCommand = new ValidationCommand<object>(ExecuteSliderState);
        }

        public ICommand SliderOnOffCommand { get; }
        public ICommand SliderStateCommand { get; }

        private bool ExecuteValidation(bool Param)
        {
            if (Param)
            {
                // 스위치 ON 될 때 액션 실행
                return true;
            }
            else
            {
                // 스위치 OFF될 때 액션 실행
                return true;
            }
        }

        private bool ExecuteSliderState(object Param)
        {
            // 스위치의 초기 상태값을 결정
            // false : OFF
            // true : ON
            return true;
        }
    }
}
