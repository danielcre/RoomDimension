using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
        private void Update() {
            if (roomWidthTextbox == null || roomHeightTextbox == null || roomLengthTextbox == null || paintPerLitreTextbox == null || floorAreaLabel == null || roomVolumeLabel == null || paintRequiredLabel == null)
                return;

            double roomWidth, roomLength, roomHeight, paintPerLitre;
            bool invalidValue = false;

            if (!Double.TryParse(roomWidthTextbox.Text, out roomWidth) || roomWidth <= 0)
            {
                invalidValue = true;
                roomWidthTextbox.Background = new SolidColorBrush(Colors.LightCoral);
            }
            else
                roomWidthTextbox.ClearValue(TextBox.BackgroundProperty);

            if (!Double.TryParse(roomLengthTextbox.Text, out roomLength) || roomLength <= 0)
            {
                invalidValue = true;
                roomLengthTextbox.Background = new SolidColorBrush(Colors.LightCoral);
            }
            else
                roomLengthTextbox.ClearValue(TextBox.BackgroundProperty);

            if (!Double.TryParse(roomHeightTextbox.Text, out roomHeight) || roomHeight <= 0)
            {
                invalidValue = true;
                roomHeightTextbox.Background = new SolidColorBrush(Colors.LightCoral);
            }
            else
                roomHeightTextbox.ClearValue(TextBox.BackgroundProperty);

            if (!Double.TryParse(paintPerLitreTextbox.Text, out paintPerLitre) || paintPerLitre <= 0)
            {
                invalidValue = true;
                paintPerLitreTextbox.Background = new SolidColorBrush(Colors.LightCoral);
            }
            else
                paintPerLitreTextbox.ClearValue(TextBox.BackgroundProperty);

            if (invalidValue)
            {
                floorAreaLabel.Content = "<Invalid Input>";
                roomVolumeLabel.Content = "<Invalid Input>";
                paintRequiredLabel.Content = "<Invalid Input>";
            }
            else
            {
                floorAreaLabel.Content = (roomWidth * roomLength) + " m²";
                roomVolumeLabel.Content = (roomWidth * roomLength * roomHeight) + " m³";
                double wallArea = (2 * roomWidth * roomHeight) + (2 * roomLength * roomHeight);
                paintRequiredLabel.Content = (wallArea / paintPerLitre).ToString("N2") + " litres";
            }
        }
    }
}
