using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using RoomDimensionCalculations;

namespace RoomDimensions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Update();
        }


        private void textChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
        private double CheckTextbox(TextBox textBox, ref bool invalidValue)
        {
            double textBoxValue;
            if (!Double.TryParse(textBox.Text, out textBoxValue) || textBoxValue <= 0)
            {
                invalidValue = true;
                textBox.Background = new SolidColorBrush(Colors.LightCoral);
            }
            else
                textBox.ClearValue(TextBox.BackgroundProperty);

            return textBoxValue;
        }
        private void Update() {
            if (roomWidthTextbox == null || roomHeightTextbox == null || roomLengthTextbox == null || paintPerLitreTextbox == null || floorAreaLabel == null || roomVolumeLabel == null || paintRequiredLabel == null)
                return;

            double roomWidth, roomLength, roomHeight, paintPerLitre;
            bool invalidValue = false;

            roomWidth = CheckTextbox(roomWidthTextbox, ref invalidValue);
            roomLength = CheckTextbox(roomLengthTextbox, ref invalidValue);
            roomHeight = CheckTextbox(roomHeightTextbox, ref invalidValue);
            paintPerLitre = CheckTextbox(paintPerLitreTextbox, ref invalidValue);

            if (invalidValue)
            {
                floorAreaLabel.Content = "<Invalid Input>";
                roomVolumeLabel.Content = "<Invalid Input>";
                paintRequiredLabel.Content = "<Invalid Input>";
            }
            else
            {
                floorAreaLabel.Content = RoomMath.floorArea(roomWidth, roomLength) + " m²";
                roomVolumeLabel.Content = RoomMath.roomVolume(roomWidth, roomLength, roomHeight) + " m³";
                paintRequiredLabel.Content = RoomMath.paintRequired(roomWidth, roomLength, roomHeight, paintPerLitre).ToString("N2") + " litres";
            }
            
        }
    }
}
